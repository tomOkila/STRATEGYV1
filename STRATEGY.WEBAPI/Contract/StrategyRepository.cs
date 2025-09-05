using Microsoft.EntityFrameworkCore;
using STRATEGY.CLIENT.DTOs;
using STRATEGY.CLIENT.Models;
using STRATEGY.WEBAPI.Data;

namespace STRATEGY.WEBAPI.Contract
{
    public class StrategyRepository(AppDbContext _appDbContext, IConfiguration _config) : IStrategy
    {
        public async Task<GeneralResponse> CreateDepartmentAsync(Department model)
        {
            var response = await FindDepartmentByNameAsync(model.DepartmentName);
            if (response != null)
            {
                return new GeneralResponse(false, "Department already exists");
            }
            _appDbContext.Departments.Add(new Department()
            {
                DepartmentName = model.DepartmentName,
                DepartmentManager = model.DepartmentManager,
                CreateDate = DateTime.Now
            });
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Department Added Successfully");
        }

        public async Task<GeneralResponse> CreateEmployeeAsync(Employee model)
        {
            var check = await _appDbContext.Employees.FirstOrDefaultAsync(_ => _.EmployeeName.ToLower() == model.EmployeeName.ToLower());
            if (check != null)
                return new GeneralResponse(false, "Employee already exists");
            _appDbContext.Employees.Add(model);
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Employee Added Successfully");
        }

        public async Task<GeneralResponse> CreatePillarAsync(Pillar model)
        {
            var response = await FindPillarByNameAsync(model.PillarName);
            if (response != null)
            {
                return new GeneralResponse(false, "Pillar already exists");
            }
            _appDbContext.Pillars.Add(new Pillar()
            {
                PillarName = model.PillarName,
                RegistrationDate = model.RegistrationDate,
                PillarRecorder = model.PillarRecorder,
                CreateDate = DateTime.Now
            });
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Pillar Added Successfully");
        }

        public async Task<GeneralResponse> CreateStrategicObjectivesAsync(StrategicObjective model)
        {
            //check if pillar exists
            var respPillar = await FindPillarByIDAsync(model.PillarId);
            if (respPillar == null)
            {
                return new GeneralResponse(false, "Pillar doesn't exist");
            }   


            var response = await FindStrategicObjectiveByNameAsync(model.TargetName);
            if (response != null)
            {
                return new GeneralResponse(false, "Strategic Objective already exists");
            }
            _appDbContext.StrategicObjectives.Add(new StrategicObjective()
            {
                TargetName = model.TargetName,
                PillarId = model.PillarId,
                GoalScoreDate = model.GoalScoreDate,
                GoalScorerName = model.GoalScorerName,
                CreateDate = DateTime.Now
            });
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Strategic Objective Added Successfully");
        }


        public async Task<GeneralResponse> CreateStrategicPlanAsync(StrategicPlan model)
        {
            //check if pillar exists
            var respPillar = await FindPillarByIDAsync(model.PillarID);
            if (respPillar == null)
            {
                return new GeneralResponse(false, "Pillar doesn't exist");
            }

            //check if strategic objective exists
            var respSO = await FindStrategicObjectiveByIDAsync(model.SOId);
            if (respSO == null)
            {
                return new GeneralResponse(false, "Strategic Objective doesn't exist");
            }

            //check if program schedule exists
            var respSODetail = await FindDetailedStrategicObjectiveByIDAsync(model.DetailedId);
            if (respSODetail == null)
            {
                return new GeneralResponse(false, "Detailed Strategic Objective doesn't exist");
            }

            //check if program schedule exists
            var respProgram = await FindDetailedPorgramScheduleByIDAsync(model.ProgramScheduleId);
            if (respProgram == null)
            {
                return new GeneralResponse(false, "Program schedule doesn't exist");
            }

           
            var response = await FindStrategicPlanByIDAsync(model.StrategicPlanName);
            if (response != null)
            {
                return new GeneralResponse(false, "Strategic Plan already exists");
            }

            _appDbContext.StrategicPlans.Add(new StrategicPlan()
            {
                StrategicPlanName = model.StrategicPlanName,
                PillarID = model.PillarID,
                SOId = model.SOId,
                DetailedId = model.DetailedId,
                ProgramScheduleId = model.ProgramScheduleId,
                CreateDate = DateTime.Now
            });
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Strategic Plan Added Successfully");
        }


        public async Task<GeneralResponse> CreateDetailedStrategicObjectivesAsync(DetailedSO model)
        {
            //check if strategic objective exists
            var respSO = await FindStrategicObjectiveByIDAsync(model.SOId);
            if (respSO == null)
            {
                return new GeneralResponse(false, "Strategic Objective doesn't exist");
            }


            var response = await FindDetailedStrategicObjectiveByNameAsync(model.DetailedTargetName);
            if (response != null)
            {
                return new GeneralResponse(false, "Detailed Strategic Objective already exists");
            }
            _appDbContext.DetailedSO.Add(new DetailedSO()
            {
                DetailedTargetName = model.DetailedTargetName,
                DetailedTargetHistory = model.DetailedTargetHistory,
                DetailedScorerName = model.DetailedScorerName,
                SOId = model.SOId,
                CreateDate = DateTime.Now
            });
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Detailed Strategic Objective Added Successfully");
        }

        public async Task<GeneralResponse> CreateProgramScheduleAsync(ProgramSchedule model)
        {
            //check if program schedule exists
            var respSO = await FindDetailedStrategicObjectiveByIDAsync(model.DetailedId);
            if (respSO == null)
            {
                return new GeneralResponse(false, "Detailed Startegic Objective doesn't exist");
            }


            var response = await FindDetailedPorgramScheduleByNameAsync(model.ProgramRegistrarName);
            if (response != null)
            {
                return new GeneralResponse(false, "Program Schedule already exists");
            }
            _appDbContext.ProgramSchedules.Add(new ProgramSchedule()
            {
                RegistrationDate = model.RegistrationDate,
                ProgramRegistrarName = model.ProgramRegistrarName,
                DetailedId = model.DetailedId,
                CreateDate = DateTime.Now
            });
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Program Schedule  Added Successfully");
        }


        public async Task<GeneralResponse> DeleteDepartmentAsync(Department model)
        {

            var role = await _appDbContext.Departments.FindAsync(model.DepartmentId);
            if (role == null)
                return new GeneralResponse(false, "Department not found");
            _appDbContext.Departments.Remove(role);
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Department Deleted Successfully");
        }

        public async Task<GeneralResponse> DeleteEmployeeAsync(Employee model)
        {
            var employee = await _appDbContext.Employees.FindAsync(model.EmployeeId);
            if (employee == null)
                return new GeneralResponse(false, "Employee not found");
            _appDbContext.Employees.Remove(employee);
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Employee Deleted Successfully");
        }

        public async Task<GeneralResponse> DeletePillarAsync(Pillar model)
        {
            var role = await _appDbContext.Pillars.FindAsync(model.PillarID);
            if (role == null)
                return new GeneralResponse(false, "Pillar not found");
            _appDbContext.Pillars.Remove(role);
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Pillars Deleted Successfully");
        }

        public async Task<GeneralResponse> DeleteStrategicObjectivesAsync(StrategicObjective model)
        {

            var role = await _appDbContext.StrategicObjectives.FindAsync(model.SOId);
            if (role == null)
                return new GeneralResponse(false, "Department not found");
            _appDbContext.StrategicObjectives.Remove(role);
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Strategic Objective Deleted Successfully");
        }

        public async Task<GeneralResponse> DeleteDetailedStrategicObjectivesAsync(DetailedSO model)
        {
            var respDetail = await _appDbContext.DetailedSO.FindAsync(model.DetailedId);
            if (respDetail == null)
                return new GeneralResponse(false, "Detailed Strategic Objective not found");
            _appDbContext.DetailedSO.Remove(respDetail);
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Detailed Strategic Objective Deleted Successfully");
        }

        public async Task<GeneralResponse> DeleteProgramScheduleAsync(ProgramSchedule model)
        {
            var respDetail = await _appDbContext.ProgramSchedules.FindAsync(model.ProgramScheduleId);
            if (respDetail == null)
                return new GeneralResponse(false, "Program Schedule not found");
            _appDbContext.ProgramSchedules.Remove(respDetail);
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Program Schedule Deleted Successfully");
        }

        public async Task<GeneralResponse> DeleteStrategicPlanAsync(StrategicPlan model)
        {
            var respDetail = await _appDbContext.StrategicPlans.FindAsync(model.StrategicPlanID);
            if (respDetail == null)
                return new GeneralResponse(false, "Strategic plan not found");
            _appDbContext.StrategicPlans.Remove(respDetail);
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Strategic plan Deleted Successfully");  
        }

        public async Task<List<Department>> GetDepartmentAsync() =>
await _appDbContext.Departments.ToListAsync();

        public async Task<List<Employee>> GetEmployeeAsync() =>
       await _appDbContext.Employees.OrderBy(i => i.EmployeeId)
       .AsNoTracking()
       .Include(gd => gd.Departments)
       .ToListAsync();
        public async Task<List<Pillar>> GetPillarAsync() =>
await _appDbContext.Pillars.ToListAsync();

        public async Task<List<StrategicObjective>> GetStrategicObjectivesAsync() =>
        await _appDbContext.StrategicObjectives.OrderBy(i => i.SOId)
        .AsNoTracking()
        .Include(gd => gd.Pillars)
        .ToListAsync();


        public async Task<List<DetailedSO>> GetDetailedStrategicObjectivesAsync() =>
        await _appDbContext.DetailedSO.OrderBy(i => i.SOId)
        .AsNoTracking()
        .Include(gd => gd.StrategicObjective)
        .ToListAsync();


        public async Task<List<ProgramSchedule>> GetProgramScheduleAsync() =>
        await _appDbContext.ProgramSchedules.OrderBy(i => i.ProgramScheduleId)
        .AsNoTracking()
        .Include(gd => gd.DetailedSO)
        .ToListAsync();

        public async Task<List<StrategicPlanReponse>> GetStrategicPlanAsync()
        {
            var result = (from a in _appDbContext.StrategicPlans
                          join c in _appDbContext.Pillars on a.PillarID equals c.PillarID
                          join d in _appDbContext.StrategicObjectives on a.SOId equals d.SOId
                          join e in _appDbContext.DetailedSO on a.DetailedId equals e.DetailedId
                          join f in _appDbContext.ProgramSchedules on a.ProgramScheduleId equals f.ProgramScheduleId
                          select new { StrategicPlans = a, Pillars = c, StrategicObjectives = d, DetailedSO = e, ProgramSchedules = f });

            List<StrategicPlanReponse> response1 = new List<StrategicPlanReponse>();
            foreach (var user in result)
            {
                StrategicPlanReponse response = new StrategicPlanReponse();
                response.StrategicPlanID = user.StrategicPlans.StrategicPlanID;
                response.StrategicPlanName = user.StrategicPlans.StrategicPlanName;
                response.PillarID = user.Pillars.PillarID;
                response.PillarName = user.Pillars.PillarName;
                response.SOId = user.StrategicObjectives.SOId;
                response.TargetName = user.StrategicObjectives.TargetName;
                response.DetailedId = user.DetailedSO.DetailedId;
                response.DetailedTargetName = user.DetailedSO.DetailedTargetName;
                response.ProgramScheduleId = user.ProgramSchedules.ProgramScheduleId;
                response.ProgramRegistrarName = user.ProgramSchedules.ProgramRegistrarName;
                response1.Add(response);
            }

            return response1.ToList();
        }


        public async Task<GeneralResponse> UpdateDepartmentAsync(Department model)
        {
            model.UpdatedDate = DateTime.Now;

            _appDbContext.Departments.Update(model);
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Department Updated Successfully");
        }

        public async Task<GeneralResponse> UpdateEmployeeAsync(Employee model)
        {
            var emp = await _appDbContext.Employees.FindAsync(model.EmployeeId);
            if (emp == null)
            {
                return new GeneralResponse(false, "Employee doesn't exist");
            }
            else
            {
                emp.EmployeeName = model.EmployeeName;
                emp.DepartmentID = model.DepartmentID;
                emp.IDNumber = model.IDNumber;
                emp.MobileNumber = model.MobileNumber;
                emp.RegistrationDate = model.RegistrationDate;
                emp.EmailAddress = model.EmailAddress;
                emp.UpdatedBy = model.UpdatedBy;
                emp.UpdatedDate = DateTime.Now;
                await _appDbContext.SaveChangesAsync();
                return new GeneralResponse(true, "Employee Updated Successfully");
            }
        }

        public async Task<GeneralResponse> UpdatePillarAsync(Pillar model)
        {
            model.UpdatedDate = DateTime.Now;
            _appDbContext.Pillars.Update(model);
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Pillar Updated Successfully");
        }

        public async Task<GeneralResponse> UpdateStrategicObjectivesAsync(StrategicObjective model)
        {
            //check if pillar exists
            var respPillar = await FindPillarByIDAsync(model.PillarId);
            if (respPillar == null)
            {
                return new GeneralResponse(false, "Pillar doesn't exist");
            }

            var strategocObj = await _appDbContext.StrategicObjectives.FindAsync(model.SOId);
            if (strategocObj == null)
            {
                return new GeneralResponse(false, "Strategic Objective doesn't exist");
            }
            else
            {
                strategocObj.TargetName = model.TargetName;
                strategocObj.PillarId = model.PillarId;
                strategocObj.GoalScoreDate = model.GoalScoreDate;
                strategocObj.GoalScorerName = model.GoalScorerName;
                strategocObj.UpdatedBy = model.UpdatedBy;
                strategocObj.CreateDate = strategocObj.CreateDate;
                strategocObj.UpdatedDate = DateTime.Now;
                await _appDbContext.SaveChangesAsync();
                return new GeneralResponse(true, "Strategic Objective Updated Successfully");
            }
        }

        public async Task<GeneralResponse> UpdateDetailedStrategicObjectivesAsync(DetailedSO model)
        {
            var emp = await _appDbContext.DetailedSO.FindAsync(model.DetailedId);
            if (emp == null)
            {
                return new GeneralResponse(false, "Detailed Strategic Objectives doesn't exist");
            }
            else
            {
                emp.DetailedTargetName = model.DetailedTargetName;
                emp.DetailedTargetHistory = model.DetailedTargetHistory;
                emp.DetailedScorerName = model.DetailedScorerName;
                emp.SOId = model.SOId;
                emp.CreateDate = emp.CreateDate;
                emp.UpdatedBy = model.UpdatedBy;
                emp.UpdatedDate = DateTime.Now;
                await _appDbContext.SaveChangesAsync();
                return new GeneralResponse(true, "Detailed Strategic Objectives Updated Successfully");
            }
        }

        public async Task<GeneralResponse> UpdateProgramScheduleAsync(ProgramSchedule model)
        {
            //check if detailed strategic objectives
            var respSchedule = await FindDetailedStrategicObjectiveByIDAsync(model.DetailedId);
            if (respSchedule == null)
            {
                return new GeneralResponse(false, "Detailed Strategic Objective doesn't exist");
            }

            var strategocObj = await _appDbContext.ProgramSchedules.FindAsync(model.ProgramScheduleId);
            if (strategocObj == null)
            {
                return new GeneralResponse(false, "Program Schedule doesn't exist");
            }
            else
            {
                strategocObj.RegistrationDate = model.RegistrationDate;
                strategocObj.ProgramRegistrarName = model.ProgramRegistrarName;
                strategocObj.DetailedId = model.DetailedId;

                strategocObj.UpdatedBy = model.UpdatedBy;
                strategocObj.CreateDate = strategocObj.CreateDate;
                strategocObj.UpdatedDate = DateTime.Now;
                await _appDbContext.SaveChangesAsync();
                return new GeneralResponse(true, "Program Schedule Updated Successfully");
            }
        }

        public async Task<GeneralResponse> UpdateStrategicPlanAsync(StrategicPlan model)
        {
            //check if pillar exists
            var respPillar = await FindPillarByIDAsync(model.PillarID);
            if (respPillar == null)
            {
                return new GeneralResponse(false, "Pillar doesn't exist");
            }

            //check if strategic objective exists
            var respSO = await FindStrategicObjectiveByIDAsync(model.SOId);
            if (respSO == null)
            {
                return new GeneralResponse(false, "Strategic Objective doesn't exist");
            }

            //check if program schedule exists
            var respSODetail = await FindDetailedStrategicObjectiveByIDAsync(model.DetailedId);
            if (respSODetail == null)
            {
                return new GeneralResponse(false, "Detailed Strategic Objective doesn't exist");
            }

            //check if program schedule exists
            var respProgram = await FindDetailedPorgramScheduleByIDAsync(model.DetailedId);
            if (respProgram == null)
            {
                return new GeneralResponse(false, "Program schedule doesn't exist");
            }

            var strategicPlanResp = await _appDbContext.StrategicPlans.FindAsync(model.StrategicPlanID);
            if (strategicPlanResp == null)
            {
                return new GeneralResponse(false, "Strategic plan doesn't exist");
            }
            else
            {
                strategicPlanResp.StrategicPlanName = model.StrategicPlanName;
                strategicPlanResp.PillarID = model.PillarID;
                strategicPlanResp.SOId = model.SOId;
                strategicPlanResp.DetailedId = model.DetailedId;
                strategicPlanResp.UpdatedBy = model.UpdatedBy;
                strategicPlanResp.CreateDate = strategicPlanResp.CreateDate;
                strategicPlanResp.UpdatedDate = DateTime.Now;
                await _appDbContext.SaveChangesAsync();
                return new GeneralResponse(true, "Strategic plan Updated Successfully");
            }
        }

        private async Task<Department> FindDepartmentByNameAsync(string departmentName)
 => await _appDbContext.Departments.FirstOrDefaultAsync(u => u.DepartmentName == departmentName);
        private async Task<Pillar> FindPillarByNameAsync(string pillarName)
=> await _appDbContext.Pillars.FirstOrDefaultAsync(u => u.PillarName == pillarName);


        private async Task<Pillar> FindPillarByIDAsync(int pillarID)
=> await _appDbContext.Pillars.FirstOrDefaultAsync(u => u.PillarID == pillarID);
        private async Task<StrategicObjective> FindStrategicObjectiveByNameAsync(string strategicObjectives)
=> await _appDbContext.StrategicObjectives.FirstOrDefaultAsync(u => u.TargetName == strategicObjectives);

        private async Task<StrategicObjective> FindStrategicObjectiveByIDAsync(int strategicObjectiveID)
=> await _appDbContext.StrategicObjectives.FirstOrDefaultAsync(u => u.SOId == strategicObjectiveID);


        private async Task<DetailedSO> FindDetailedStrategicObjectiveByNameAsync(string detailedStrategicObjectives)
=> await _appDbContext.DetailedSO.FirstOrDefaultAsync(u => u.DetailedTargetName == detailedStrategicObjectives);

        private async Task<DetailedSO> FindDetailedStrategicObjectiveByIDAsync(int DetailedID)
=> await _appDbContext.DetailedSO.FirstOrDefaultAsync(u => u.DetailedId == DetailedID);

        private async Task<ProgramSchedule> FindDetailedPorgramScheduleByNameAsync(string ProgramRegistrarName)
=> await _appDbContext.ProgramSchedules.FirstOrDefaultAsync(u => u.ProgramRegistrarName == ProgramRegistrarName);

        private async Task<ProgramSchedule> FindDetailedPorgramScheduleByIDAsync(int ProgramScheduleID)
=> await _appDbContext.ProgramSchedules.FirstOrDefaultAsync(u => u.ProgramScheduleId == ProgramScheduleID);


        private async Task<StrategicPlan> FindStrategicPlanByIDAsync(string strategicPlanName)
=> await _appDbContext.StrategicPlans.FirstOrDefaultAsync(u => u.StrategicPlanName == strategicPlanName);

     
    }
}