using STRATEGY.CLIENT.DTOs;
using STRATEGY.CLIENT.Models;

namespace STRATEGY.WEBAPI.Contract
{
    public interface IStrategy
    {
        Task<GeneralResponse> CreateDepartmentAsync(Department model);
        Task<List<Department>> GetDepartmentAsync();
        Task<GeneralResponse> UpdateDepartmentAsync(Department model);
        Task<GeneralResponse> DeleteDepartmentAsync(Department model);

        Task<GeneralResponse> CreateEmployeeAsync(Employee model);
        Task<List<Employee>> GetEmployeeAsync();
        Task<GeneralResponse> UpdateEmployeeAsync(Employee model);
        Task<GeneralResponse> DeleteEmployeeAsync(Employee model);

        Task<GeneralResponse> CreatePillarAsync(Pillar model);
        Task<List<Pillar>> GetPillarAsync();
        Task<GeneralResponse> UpdatePillarAsync(Pillar model);
        Task<GeneralResponse> DeletePillarAsync(Pillar model);

        Task<GeneralResponse> CreateStrategicObjectivesAsync(StrategicObjective model);
        Task<List<StrategicObjective>> GetStrategicObjectivesAsync();
        Task<GeneralResponse> UpdateStrategicObjectivesAsync(StrategicObjective model);
        Task<GeneralResponse> DeleteStrategicObjectivesAsync(StrategicObjective model);

        Task<GeneralResponse> CreateDetailedStrategicObjectivesAsync(DetailedSO model);
        Task<List<DetailedSO>> GetDetailedStrategicObjectivesAsync();
        Task<GeneralResponse> UpdateDetailedStrategicObjectivesAsync(DetailedSO model);
        Task<GeneralResponse> DeleteDetailedStrategicObjectivesAsync(DetailedSO model);


        Task<GeneralResponse> CreateProgramScheduleAsync(ProgramSchedule model);
        Task<List<ProgramSchedule>> GetProgramScheduleAsync();
        Task<GeneralResponse> UpdateProgramScheduleAsync(ProgramSchedule model);
        Task<GeneralResponse> DeleteProgramScheduleAsync(ProgramSchedule model);

        Task<GeneralResponse> CreateStrategicPlanAsync(StrategicPlan model);
        Task<List<StrategicPlanReponse>> GetStrategicPlanAsync();
        Task<GeneralResponse> UpdateStrategicPlanAsync(StrategicPlan model);
        Task<GeneralResponse> DeleteStrategicPlanAsync(StrategicPlan model);


        Task<GeneralResponse> CreatePlanAsync(EditPlan model);
        Task<List<PlanResponse>> GetPlanAsync();
        Task<List<PlanDocuments>> GetPlanDocumentsAsync(EditPlanDocument model);
        Task<GeneralResponse> UpdatePlanAsync(EditPlan model);
        Task<GeneralResponse> DeletePlanAsync(Plan model);
        Task<GeneralResponse> DeletePlanDocumentAsync(PlanDocuments model);
    }
}
