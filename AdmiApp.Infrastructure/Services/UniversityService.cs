using AdmiApp.Appl.Interfaces;
using AdmiApp.Core.DTO;
using AdmiApp.Core.Models;
using AdmiApp.Core.Responses;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace AdmiApp.Infrastructure.Services
{
    public class UniversityService : IUniversityService
    {
        private IConfiguration _configuration;
        private string _baseUrl;

        public UniversityService(
            IConfiguration configuration)
        {
            _configuration = configuration;
            _baseUrl = _configuration["WebApiUrls:AdmiWebAPI"]!;
        }

        public async Task<List<UniversityAdmissionResponseDTO>> GetUniversitiesList(string request)
        {
            var returnResponse = new List<UniversityAdmissionResponseDTO>();
            using (var client = new HttpClient())
            {
                var url = $"{_baseUrl}{APIs.GetUniversitiesBySubjects}?{request}";
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string contentStr = await response.Content.ReadAsStringAsync();
                    returnResponse = JsonConvert.DeserializeObject<List<UniversityAdmissionResponseDTO>>(contentStr);
                }
            }

            return returnResponse;
        }

        public async Task<UniversityInfoDTO> GetUniversityInfo(string request)
        {
            var returnResponse = new UniversityInfoDTO();
            using (var client = new HttpClient())
            {
                var url = $"{_baseUrl}{APIs.UniversityInfo}?{request}";
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string contentStr = await response.Content.ReadAsStringAsync();
                    returnResponse = JsonConvert.DeserializeObject<UniversityInfoDTO>(contentStr);
                }
            }

            return returnResponse;
        }

        public async Task<List<UniversityAdmissionResponseDTO>> GetUniversitiesListByName(string name)
        {
            var returnResponse = new List<UniversityAdmissionResponseDTO>();
            using (var client = new HttpClient())
            {
                var url = $"{_baseUrl}{APIs.GetUniversitiesByInfo}?{name}";
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string contentStr = await response.Content.ReadAsStringAsync();
                    returnResponse = JsonConvert.DeserializeObject<List<UniversityAdmissionResponseDTO>>(contentStr);
                }
            }

            return returnResponse;
        }

		public async Task<List<UniversityAdmissionResponseDTO>> GetUniversitiesListBySpeciality(string speciality)
		{
			var returnResponse = new List<UniversityAdmissionResponseDTO>();
			using (var client = new HttpClient())
			{
				var url = $"{_baseUrl}{APIs.GetAllUniversitiesBySpeciality}?{speciality}";
				var response = await client.GetAsync(url);
				if (response.IsSuccessStatusCode)
				{
					string contentStr = await response.Content.ReadAsStringAsync();
					returnResponse = JsonConvert.DeserializeObject<List<UniversityAdmissionResponseDTO>>(contentStr);
				}
			}

			return returnResponse;
		}

		public async Task<MainListStringResponse> GetAllUniversitiesNames()
		{
			var returnResponse = new MainListStringResponse();
			using (var client = new HttpClient())
			{
				var url = $"{_baseUrl}{APIs.GetAllUniversitiesNames}";
				var response = await client.GetAsync(url);
				if (response.IsSuccessStatusCode)
				{
					string contentStr = await response.Content.ReadAsStringAsync();
					returnResponse = JsonConvert.DeserializeObject<MainListStringResponse>(contentStr);
				}
			}

			return returnResponse;
		}

	}
}
