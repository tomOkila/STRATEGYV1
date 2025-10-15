using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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


        public async  Task<GeneralResponse> CreatePlanAsync(EditPlan model)
        {
            //check if pillar exists
            var respPillar = await FindPillarByIDAsync(model.PillarID);
            if (respPillar == null)
            {
                return new GeneralResponse(false, "Pillar doesn't exist");
            }

            //check if department exists
            var respDept = await FindDepartmentByIDAsync(model.DepartmentID);
            if (respDept == null)
            {
                return new GeneralResponse(false, "Department doesn't exist");
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


            var response = await FindPlanByIDAsync(model.UserName);
            if (response != null)
            {
                return new GeneralResponse(false, "Plan username already exists");
            }


            //if (!string.IsNullOrEmpty(model.WitnessName))
            //{
            //    Byte[] bytes = Convert.FromBase64String(model.Witness);
            //    File.WriteAllBytes(_config.GetConnectionString("PLAN_UPLOADFILE_PATH") + model.WitnessName, bytes);
            //    //assign photo details
            //    model.Witness = _config.GetConnectionString("PLAN_UPLOADFILE_DBPATH") + model.WitnessName;
            //}
            var plandetails = new Plan()
            {
                UserName = model.UserName,
                DepartmentID = model.DepartmentID,
                PillarID = model.PillarID,
                SOId = model.SOId,
                DetailedId = model.DetailedId,
                ProgramScheduleId = model.ProgramScheduleId,
                Witness = model.Witness,
                StraKeyPerfIndicators = model.StraKeyPerfIndicators,
                KeyPerfIndicatorsEvaluation = model.KeyPerfIndicatorsEvaluation,
                TargetGroup = model.TargetGroup,
                Targeted = model.Targeted,
                ActualPerformance = model.ActualPerformance,
                ActImpSteps = model.ActImpSteps,
                ExeActivityAnalysis = model.ExeActivityAnalysis,
                EntityResponsible = model.EntityResponsible,
                PartParties = model.PartParties,
                ImpStartDate = model.ImpStartDate,
                CompletionDate = model.CompletionDate,
                ProposedCost = model.ProposedCost,
                EstimatedCost = model.EstimatedCost,
                ActualCost = model.ActualCost,
                InitiativeStatus = model.InitiativeStatus,
                Evidence = model.Evidence,
                WitnessDetail = model.WitnessDetail,
                SectionComment = model.SectionComment,
                TeamComment = model.TeamComment,
                SupervisorReview = model.SupervisorReview,
                CreateDate = DateTime.Now
            };
            
            _appDbContext.Plans.Add(plandetails);
            await _appDbContext.SaveChangesAsync();


            int newStudentId = plandetails.PlanID;
            //add plan document
            if (model.WitnessName.Count > 0)
            {
                foreach (var item in model.WitnessName)
                {
                    _appDbContext.PlanDocuments.Add(new PlanDocuments()
                    {
                        PlanID = newStudentId,
                        DocumentName = item,
                        DocumentPath = _config.GetConnectionString("PLAN_UPLOADFILE_DBPATH") + item,
                        CreateDate = DateTime.Now
                    });
                }
                await _appDbContext.SaveChangesAsync();
            }

           

            return new GeneralResponse(true, "Plan Added Successfully");

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

        public async  Task<GeneralResponse> DeletePlanAsync(Plan model)
        {
            var respDetail = await _appDbContext.StrategicPlans.FindAsync(model.PlanID);
            if (respDetail == null)
                return new GeneralResponse(false, "Plan not found");
            _appDbContext.StrategicPlans.Remove(respDetail);
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Plan Deleted Successfully");
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


        public async Task<List<PlanResponse>> GetPlanAsync()
        {
            var result = (from a in _appDbContext.Plans
                          join c in _appDbContext.Pillars on a.PillarID equals c.PillarID
                          join d in _appDbContext.StrategicObjectives on a.SOId equals d.SOId
                          join e in _appDbContext.DetailedSO on a.DetailedId equals e.DetailedId
                          join f in _appDbContext.ProgramSchedules on a.ProgramScheduleId equals f.ProgramScheduleId
                          join g in _appDbContext.Departments on a.DepartmentID equals g.DepartmentId
                          select new { Plans = a, Pillars = c, StrategicObjectives = d, DetailedSO = e, ProgramSchedules = f,Departments=g });

            List<PlanResponse> response1 = new List<PlanResponse>();
            foreach (var user in result)
            {
                PlanResponse response = new PlanResponse();
                response.PlanID = user.Plans.PlanID;
                response.UserName = user.Plans.UserName;
                response.Witness = user.Plans.Witness;
                response.DepartmentID = user.Departments.DepartmentId;
                response.DepartmentName = user.Departments.DepartmentName;
                response.PillarName = user.Pillars.PillarName;
                response.PillarID = user.Pillars.PillarID;
                response.PillarName = user.Pillars.PillarName;
                response.SOId = user.StrategicObjectives.SOId;
                response.TargetName = user.StrategicObjectives.TargetName;
                response.DetailedId = user.DetailedSO.DetailedId;
                response.DetailedTargetName = user.DetailedSO.DetailedTargetName;
                response.ProgramScheduleId = user.ProgramSchedules.ProgramScheduleId;
                response.ProgramRegistrarName = user.ProgramSchedules.ProgramRegistrarName;
                response.StraKeyPerfIndicators = user.Plans.StraKeyPerfIndicators;
                response.KeyPerfIndicatorsEvaluation = user.Plans.KeyPerfIndicatorsEvaluation;
                response.TargetGroup = user.Plans.TargetGroup;
                response.Targeted = user.Plans.Targeted;
                response.ActualPerformance = user.Plans.ActualPerformance;
                response.ActImpSteps = user.Plans.ActImpSteps;
                response.ExeActivityAnalysis = user.Plans.ExeActivityAnalysis;
                response.EntityResponsible = user.Plans.EntityResponsible;
                response.PartParties = user.Plans.PartParties;
                response.ImpStartDate = user.Plans.ImpStartDate;
                response.CompletionDate = user.Plans.CompletionDate;
                response.ProposedCost = user.Plans.ProposedCost;
                response.EstimatedCost = user.Plans.EstimatedCost;
                response.ActualCost = user.Plans.ActualCost;
                response.InitiativeStatus = user.Plans.InitiativeStatus;
                response.Evidence = user.Plans.Evidence;
                response.WitnessDetail = user.Plans.WitnessDetail;
                response.SectionComment = user.Plans.SectionComment;
                response.TeamComment = user.Plans.TeamComment;
                response.SupervisorReview = user.Plans.SupervisorReview;


                response1.Add(response);
            }

            return response1.ToList();
        }


        public async Task<List<PlanDocuments>> GetPlanDocumentsAsync(EditPlanDocument model) =>
        await _appDbContext.PlanDocuments.Where(x=>x.PlanID == model.PlanID).OrderBy(i => i.PlanID)
        .AsNoTracking()
        .Include(gd => gd.Plan)
        .ToListAsync();
        

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

        public async Task<GeneralResponse> UpdatePlanAsync(EditPlan model)
        {
            //check if pillar exists
            var respPillar = await FindPillarByIDAsync(model.PillarID);
            if (respPillar == null)
            {
                return new GeneralResponse(false, "Pillar doesn't exist");
            }

            //check if department exists
            var respDept = await FindDepartmentByIDAsync(model.DepartmentID);
            if (respDept == null)
            {
                return new GeneralResponse(false, "Department doesn't exist");
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

            //if (!string.IsNullOrEmpty(model.WitnessName))
            //{
            //    Byte[] bytes = Convert.FromBase64String(model.Witness);
            //    File.WriteAllBytes(_config.GetConnectionString("PLAN_UPLOADFILE_PATH") + model.WitnessName, bytes);
            //    //assign photo details
            //    model.Witness = _config.GetConnectionString("PLAN_UPLOADFILE_DBPATH") + model.WitnessName;
            //}


            var strategicPlanResp = await _appDbContext.Plans.FindAsync(model.PlanID);
            if (strategicPlanResp == null)
            {
                return new GeneralResponse(false, "Plan doesn't exist");
            }
            else
            {
                strategicPlanResp.PlanID = model.PlanID;
                strategicPlanResp.UserName = model.UserName;
                strategicPlanResp.DepartmentID = model.DepartmentID;
                strategicPlanResp.PillarID = model.PillarID;
                strategicPlanResp.SOId = model.SOId;
                strategicPlanResp.DetailedId = model.DetailedId;
                strategicPlanResp.Witness = model.Witness;

                strategicPlanResp.StraKeyPerfIndicators = model.StraKeyPerfIndicators;
                strategicPlanResp.KeyPerfIndicatorsEvaluation = model.KeyPerfIndicatorsEvaluation;
                strategicPlanResp.TargetGroup = model.TargetGroup;
                strategicPlanResp.Targeted = model.Targeted;
                strategicPlanResp.ActualPerformance = model.ActualPerformance;
                strategicPlanResp.ActImpSteps = model.ActImpSteps;
                strategicPlanResp.ExeActivityAnalysis = model.ExeActivityAnalysis;
                strategicPlanResp.EntityResponsible = model.EntityResponsible;
                strategicPlanResp.PartParties = model.PartParties;
                strategicPlanResp.ImpStartDate = model.ImpStartDate;
                strategicPlanResp.CompletionDate = model.CompletionDate;
                strategicPlanResp.ProposedCost = model.ProposedCost;
                strategicPlanResp.EstimatedCost = model.EstimatedCost;
                strategicPlanResp.ActualCost = model.ActualCost;
                strategicPlanResp.InitiativeStatus = model.InitiativeStatus;
                strategicPlanResp.Evidence = model.Evidence;
                strategicPlanResp.WitnessDetail = model.WitnessDetail;
                strategicPlanResp.SectionComment = model.SectionComment;
                strategicPlanResp.TeamComment = model.TeamComment;
                strategicPlanResp.SupervisorReview = model.SupervisorReview;

                strategicPlanResp.UpdatedBy = model.UpdatedBy;
                strategicPlanResp.CreateDate = strategicPlanResp.CreateDate;
                strategicPlanResp.UpdatedDate = DateTime.Now;
                await _appDbContext.SaveChangesAsync();


                //delete existing documents
                _appDbContext.PlanDocuments
               .Where(e => e.PlanID == model.PlanID)
               .ExecuteDelete();

                //add plan document
                if (model.WitnessName.Count > 0)
                {
                    foreach (var item in model.WitnessName)
                    {
                        _appDbContext.PlanDocuments.Add(new PlanDocuments()
                        {
                            PlanID = model.PlanID,
                            DocumentName = item,
                            DocumentPath = _config.GetConnectionString("PLAN_UPLOADFILE_DBPATH") + item,
                            CreateDate = DateTime.Now
                        });
                    }
                    await _appDbContext.SaveChangesAsync();
                }

                return new GeneralResponse(true, "Plan Updated Successfully");
            }

        }

        private async Task<Department> FindDepartmentByNameAsync(string departmentName)
 => await _appDbContext.Departments.FirstOrDefaultAsync(u => u.DepartmentName == departmentName);

        private async Task<Department> FindDepartmentByIDAsync(int departmentID)
=> await _appDbContext.Departments.FirstOrDefaultAsync(u => u.DepartmentId == departmentID);

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

        private async Task<Plan> FindPlanByIDAsync(string userName)
=> await _appDbContext.Plans.FirstOrDefaultAsync(u => u.UserName == userName);


     
    }
}