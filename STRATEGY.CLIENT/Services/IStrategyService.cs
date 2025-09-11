using STRATEGY.CLIENT.DTOs;
using STRATEGY.CLIENT.Models;

namespace STRATEGY.CLIENT.Services
{
    public interface IStrategyService
    {
        Task<GeneralResponse> CreateDepartmentAsync(Department model);
        Task<List<Department>> GetDepartmentAsync(int SessionUserId);
        Task<GeneralResponse> UpdateDepartmentAsync(Department model);
        Task<GeneralResponse> DeleteDepartmentAsync(Department model);

        Task<GeneralResponse> CreateEmployeeAsync(Employee model);
        Task<List<Employee>> GetEmployeeAsync(int SessionUserId);
        Task<GeneralResponse> UpdateEmployeeAsync(Employee model);
        Task<GeneralResponse> DeleteEmployeeAsync(Employee model);


        Task<GeneralResponse> CreatePillarAsync(Pillar model);
        Task<List<Pillar>> GetPillarAsync(int SessionUserId);
        Task<GeneralResponse> UpdatePillarAsync(Pillar model);
        Task<GeneralResponse> DeletePillarAsync(Pillar model);

        Task<GeneralResponse> CreateStrategicObjectivesAsync(StrategicObjective model);
        Task<List<StrategicObjective>> GetStrategicObjectivesAsync(int SessionUserId);
        Task<GeneralResponse> UpdateStrategicObjectivesAsync(StrategicObjective model);
        Task<GeneralResponse> DeleteStrategicObjectivesAsync(StrategicObjective model);

        Task<GeneralResponse> CreateDetailedStrategicObjectivesAsync(DetailedSO model);
        Task<List<DetailedSO>> GetDetailedStrategicObjectivesAsync(int SessionUserId);
        Task<GeneralResponse> UpdateDetailedStrategicObjectivesAsync(DetailedSO model);
        Task<GeneralResponse> DeleteDetailedStrategicObjectivesAsync(DetailedSO model);


        Task<GeneralResponse> CreateProgramScheduleAsync(ProgramSchedule model);
        Task<List<ProgramSchedule>> GetProgramScheduleAsync(int SessionUserId);
        Task<GeneralResponse> UpdateProgramScheduleAsync(ProgramSchedule model);
        Task<GeneralResponse> DeleteProgramScheduleAsync(ProgramSchedule model);

        Task<GeneralResponse> CreateStrategicPlanAsync(StrategicPlan model);
        Task<List<StrategicPlanReponse>> GetStrategicPlanAsync(int SessionUserId);
        Task<GeneralResponse> UpdateStrategicPlanAsync(StrategicPlan model);
        Task<GeneralResponse> DeleteStrategicPlanAsync(StrategicPlan model);


        Task<GeneralResponse> CreatePlanAsync(EditPlan model);
        Task<List<PlanResponse>> GetPlanAsync(int SessionUserId);
        Task<GeneralResponse> UpdatePlanAsync(EditPlan model);
        Task<GeneralResponse> DeletePlanAsync(Plan model);
    }
}
