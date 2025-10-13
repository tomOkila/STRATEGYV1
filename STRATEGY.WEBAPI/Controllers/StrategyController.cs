using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STRATEGY.CLIENT.DTOs;
using STRATEGY.CLIENT.Models;
using STRATEGY.WEBAPI.Contract;

namespace STRATEGY.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsApi")]
    public class StrategyController(IStrategy strategy) : ControllerBase
    {
        [HttpPost("createDepartment")]
        public async Task<ActionResult<Department>> CreateDepartmentAsync(Department model)
        {
            var result = await strategy.CreateDepartmentAsync(model);
            return Ok(result);
        }

        [HttpGet("departmentlist")]
        public async Task<ActionResult<List<Department>>> GetDepartmentAsync()
=> Ok(await strategy.GetDepartmentAsync());

        [HttpPut("updatedepartment")]
        public async Task<IActionResult> UpdateDepartmentAsync([FromBody] Department model)
        {
            var result = await strategy.UpdateDepartmentAsync(model);
            return Ok(result);
        }

        [HttpPost("deleteDepartment")]
        public async Task<IActionResult> DeleteDepartmentAsync(Department model)
        {
            var result = await strategy.DeleteDepartmentAsync(model);
            return Ok(result);
        }


        [HttpPost("createEmployee")]
        public async Task<ActionResult<Employee>> CreateEmployeeAsync(Employee model)
        {
            var result = await strategy.CreateEmployeeAsync(model);
            return Ok(result);
        }

        [HttpGet("employeelist")]
        public async Task<ActionResult<List<Employee>>> GetEmployeeAsync()
=> Ok(await strategy.GetEmployeeAsync());

        [HttpPut("updateemployee")]
        public async Task<IActionResult> UpdateEmployeeAsync([FromBody] Employee model)
        {
            var result = await strategy.UpdateEmployeeAsync(model);
            return Ok(result);
        }

        [HttpPost("deleteEmployee")]
        public async Task<IActionResult> DeleteEmployeeAsync(Employee model)
        {
            var result = await strategy.DeleteEmployeeAsync(model);
            return Ok(result);
        }


        [HttpPost("createPillar")]
        public async Task<ActionResult<Pillar>> CreatePillarAsync(Pillar model)
        {
            var result = await strategy.CreatePillarAsync(model);
            return Ok(result);
        }

        [HttpGet("pillarlist")]
        public async Task<ActionResult<List<Pillar>>> GetPillarAsync()
=> Ok(await strategy.GetPillarAsync());

        [HttpPut("updatePillar")]
        public async Task<IActionResult> UpdatePillarAsync([FromBody] Pillar model)
        {
            var result = await strategy.UpdatePillarAsync(model);
            return Ok(result);
        }

        [HttpPost("deletePillar")]
        public async Task<IActionResult> DeletePillarAsync(Pillar model)
        {
            var result = await strategy.DeletePillarAsync(model);
            return Ok(result);
        }

        [HttpPost("createStrategicObjective")]
        public async Task<ActionResult<StrategicObjective>> CreateStrategicObjectivesAsync(StrategicObjective model)
        {
            var result = await strategy.CreateStrategicObjectivesAsync(model);
            return Ok(result);
        }

        [HttpGet("strategicObjectivelist")]
        public async Task<ActionResult<List<StrategicObjective>>> GetStrategicObjectivesAsync()
=> Ok(await strategy.GetStrategicObjectivesAsync());

        [HttpPut("updateStrategicObjective")]
        public async Task<IActionResult> UpdateStrategicObjectivesAsync([FromBody] StrategicObjective model)
        {
            var result = await strategy.UpdateStrategicObjectivesAsync(model);
            return Ok(result);
        }

        [HttpPost("deleteStrategicObjective")]
        public async Task<IActionResult> DeleteStrategicObjectivesAsync(StrategicObjective model)
        {
            var result = await strategy.DeleteStrategicObjectivesAsync(model);
            return Ok(result);
        }


        [HttpPost("createDetailedStrategicObjective")]
        public async Task<ActionResult<DetailedSO>> CreateDetailedStrategicObjectivesAsync(DetailedSO model)
        {
            var result = await strategy.CreateDetailedStrategicObjectivesAsync(model);
            return Ok(result);
        }

        [HttpGet("detailedStrategicObjectivelist")]
        public async Task<ActionResult<List<DetailedSO>>> GetDetailedStrategicObjectivesAsync()
=> Ok(await strategy.GetDetailedStrategicObjectivesAsync());

        [HttpPut("updateDetailedStrategicObjective")]
        public async Task<IActionResult> UpdateDetailedStrategicObjectivesAsync([FromBody] DetailedSO model)
        {
            var result = await strategy.UpdateDetailedStrategicObjectivesAsync(model);
            return Ok(result);
        }

        [HttpPost("deleteDetailedStrategicObjective")]
        public async Task<IActionResult> DeleteDetailedStrategicObjectivesAsync(DetailedSO model)
        {
            var result = await strategy.DeleteDetailedStrategicObjectivesAsync(model);
            return Ok(result);
        }


        [HttpPost("createProgramSchedule")]
        public async Task<ActionResult<ProgramSchedule>> CreateProgramScheduleAsync(ProgramSchedule model)
        {
            var result = await strategy.CreateProgramScheduleAsync(model);
            return Ok(result);
        }

        [HttpGet("programSchedulelist")]
        public async Task<ActionResult<List<ProgramSchedule>>> GetProgramScheduleAsync()
=> Ok(await strategy.GetProgramScheduleAsync());

        [HttpPut("updateProgramSchedule")]
        public async Task<IActionResult> UpdateProgramScheduleAsyncs([FromBody] ProgramSchedule model)
        {
            var result = await strategy.UpdateProgramScheduleAsync(model);
            return Ok(result);
        }

        [HttpPost("deleteProgramSchedule")]
        public async Task<IActionResult> DeleteProgramScheduleAsync(ProgramSchedule model)
        {
            var result = await strategy.DeleteProgramScheduleAsync(model);
            return Ok(result);
        }


        [HttpPost("createStrategicPlan")]
        public async Task<ActionResult<StrategicPlan>> CreateStrategicObjectivesAsync(StrategicPlan model)
        {
            var result = await strategy.CreateStrategicPlanAsync(model);
            return Ok(result);
        }

        [HttpGet("strategicPlanlist")]
        public async Task<ActionResult<List<StrategicPlanReponse>>> GetStrategicPlanAsync()
=> Ok(await strategy.GetStrategicPlanAsync());

        [HttpPut("updateStrategicPlan")]
        public async Task<IActionResult> UpdateStrategicPlanAsync([FromBody] StrategicPlan model)
        {
            var result = await strategy.UpdateStrategicPlanAsync(model);
            return Ok(result);
        }

        [HttpPost("deleteStrategicPlan")]
        public async Task<IActionResult> DeleteStrategicPlanAsync(StrategicPlan model)
        {
            var result = await strategy.DeleteStrategicPlanAsync(model);
            return Ok(result);
        }



        [HttpPost("createPlan")]
        public async Task<ActionResult<EditPlan>> CreatePlanAsync(EditPlan model)
        {
            var result = await strategy.CreatePlanAsync(model);
            return Ok(result);
        }

        [HttpGet("planlist")]
        public async Task<ActionResult<List<Plan>>> GetPlanAsync()
=> Ok(await strategy.GetPlanAsync());


        [HttpPost("plandocumentlist")]
        public async Task<ActionResult<List<PlanDocuments>>> GetPlanDocumentsAsync(EditPlanDocument model)
=> Ok(await strategy.GetPlanDocumentsAsync(model));

        [HttpPut("updatePlan")]
        public async Task<IActionResult> UpdatePlanAsync([FromBody] EditPlan model)
        {
            var result = await strategy.UpdatePlanAsync(model);
            return Ok(result);
        }

        [HttpPost("deletePlan")]
        public async Task<IActionResult> DeletePlanAsync(Plan model)
        {
            var result = await strategy.DeletePlanAsync(model);
            return Ok(result);
        }
    }
}
