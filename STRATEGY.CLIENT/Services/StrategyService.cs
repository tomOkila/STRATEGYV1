using STRATEGY.CLIENT.DTOs;
using STRATEGY.CLIENT.Models;
using STRATEGY.WEBAPI.Helpers;
using System.Net.Http.Json;

namespace STRATEGY.CLIENT.Services
{
    public class StrategyService(HttpClientValidator validateHttpClient) : IStrategyService
    {
        public async Task<GeneralResponse> CreateDepartmentAsync(Department model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync("api/Strategy/createDepartment", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await CreateDepartmentAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> DeleteDepartmentAsync(Department model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync($"api/Strategy/deleteDepartment", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await DeleteDepartmentAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<List<Department>> GetDepartmentAsync(int SessionUserId)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.GetAsync("api/Strategy/departmentlist");
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<List<Department>>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(SessionUserId))
                        return null!;
                    else
                        return await GetDepartmentAsync(SessionUserId);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async  Task<GeneralResponse> UpdateDepartmentAsync(Department model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PutAsJsonAsync("api/Strategy/updatedepartment", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await UpdateDepartmentAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }




        public static string CheckResponseStatus(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
                return $"Sorry unkown error occurred.{Environment.NewLine} Error Description:{Environment.NewLine} Status Code:{response.StatusCode}{Environment.NewLine}Reason Phrase:{response.ReasonPhrase}";
            else
                return null;
        }

        private bool CheckResponse(HttpResponseMessage response)
        {
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                return true;
            else
                return false;
        }

        private async Task<bool> RequestAndSetNewToken(int sessionUserId)
        {

            var getToken = await validateHttpClient.GetTokenFromLocalStorage();

            var result = await validateHttpClient.GetUnSecuredHttpClient().PostAsJsonAsync("api/user/refresh-token", new PostToken() { RefreshToken = getToken.RefreshToken, SessionUserId = sessionUserId });
            var response = await result.Content.ReadFromJsonAsync<TokenResponse>();
            if (response is null) return false;
            await validateHttpClient.SetTokenToLocalStorage(new LocalStorageDTO() { Token = response.AccessToken, RefreshToken = response.RefreshToken });
            return true;
        }

        public async Task<GeneralResponse> CreateEmployeeAsync(Employee model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync("api/Strategy/createEmployee", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await CreateEmployeeAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async  Task<List<Employee>> GetEmployeeAsync(int SessionUserId)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.GetAsync("api/Strategy/employeelist");
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<List<Employee>>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(SessionUserId))
                        return null!;
                    else
                        return await GetEmployeeAsync(SessionUserId);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> UpdateEmployeeAsync(Employee model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PutAsJsonAsync("api/Strategy/updateemployee", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await UpdateEmployeeAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> DeleteEmployeeAsync(Employee model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync($"api/Strategy/deleteEmployee", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await DeleteEmployeeAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> CreatePillarAsync(Pillar model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync("api/Strategy/createPillar", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await CreatePillarAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<List<Pillar>> GetPillarAsync(int SessionUserId)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.GetAsync("api/Strategy/pillarlist");
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<List<Pillar>>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(SessionUserId))
                        return null!;
                    else
                        return await GetPillarAsync(SessionUserId);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> UpdatePillarAsync(Pillar model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PutAsJsonAsync("api/Strategy/updatePillar", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await UpdatePillarAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> DeletePillarAsync(Pillar model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync($"api/Strategy/deletePillar", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);
                   
                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await DeletePillarAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> CreateStrategicObjectivesAsync(StrategicObjective model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync("api/Strategy/createStrategicObjective", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await CreateStrategicObjectivesAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<List<StrategicObjective>> GetStrategicObjectivesAsync(int SessionUserId)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.GetAsync("api/Strategy/strategicObjectivelist");
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<List<StrategicObjective>>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(SessionUserId))
                        return null!;
                    else
                        return await GetStrategicObjectivesAsync(SessionUserId);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> UpdateStrategicObjectivesAsync(StrategicObjective model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PutAsJsonAsync("api/Strategy/updateStrategicObjective", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await UpdateStrategicObjectivesAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> DeleteStrategicObjectivesAsync(StrategicObjective model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync($"api/Strategy/deleteStrategicObjective", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await DeleteStrategicObjectivesAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async  Task<GeneralResponse> CreateDetailedStrategicObjectivesAsync(DetailedSO model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync("api/Strategy/createDetailedStrategicObjective", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await CreateDetailedStrategicObjectivesAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<List<DetailedSO>> GetDetailedStrategicObjectivesAsync(int SessionUserId)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.GetAsync("api/Strategy/detailedStrategicObjectivelist");
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<List<DetailedSO>>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(SessionUserId))
                        return null!;
                    else
                        return await GetDetailedStrategicObjectivesAsync(SessionUserId);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async  Task<GeneralResponse> UpdateDetailedStrategicObjectivesAsync(DetailedSO model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PutAsJsonAsync("api/Strategy/updateDetailedStrategicObjective", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await UpdateDetailedStrategicObjectivesAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> DeleteDetailedStrategicObjectivesAsync(DetailedSO model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync($"api/Strategy/deleteDetailedStrategicObjective", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await DeleteDetailedStrategicObjectivesAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> CreateProgramScheduleAsync(ProgramSchedule model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync("api/Strategy/createProgramSchedule", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await CreateProgramScheduleAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<List<ProgramSchedule>> GetProgramScheduleAsync(int SessionUserId)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.GetAsync("api/Strategy/programSchedulelist");
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<List<ProgramSchedule>>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(SessionUserId))
                        return null!;
                    else
                        return await GetProgramScheduleAsync(SessionUserId);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> UpdateProgramScheduleAsync(ProgramSchedule model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PutAsJsonAsync("api/Strategy/updateProgramSchedule", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await UpdateProgramScheduleAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> DeleteProgramScheduleAsync(ProgramSchedule model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync($"api/Strategy/deleteProgramSchedule", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await DeleteProgramScheduleAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> CreateStrategicPlanAsync(StrategicPlan model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync("api/Strategy/createStrategicPlan", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await CreateStrategicPlanAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<List<StrategicPlan>> GetStrategicPlanAsync(int SessionUserId)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.GetAsync("api/Strategy/strategicPlanlist");
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<List<StrategicPlan>>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(SessionUserId))
                        return null!;
                    else
                        return await GetStrategicPlanAsync(SessionUserId);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> UpdateStrategicPlanAsync(StrategicPlan model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PutAsJsonAsync("api/Strategy/updateStrategicPlan", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await UpdateStrategicPlanAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> DeleteStrategicPlanAsync(StrategicPlan model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync($"api/Strategy/deleteStrategicPlan", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await DeleteStrategicPlanAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }
    }
}
