using AdmiApp.Appl.Interfaces;
using AdmiApp.Core.Models;
using AdmiApp.Core.Responses;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace AdmiApp.Infrastructure.Services
{
    public class ExamService : IExamService
    {
        private IConfiguration _configuration;
        private string _baseUrl;

        public ExamService(
            IConfiguration configuration)
        {
            _configuration = configuration;
            _baseUrl = _configuration["WebApiUrls:AdmiWebAPI"]!;
        }

        public async Task<GetAllExamsResponse> GetAllExams()
        {
            var returnResponse = new GetAllExamsResponse();
            using (var client = new HttpClient())
            {
                var url = $"{_baseUrl}{APIs.GetAllExams}";
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string contentStr = await response.Content.ReadAsStringAsync();
                    returnResponse = JsonConvert.DeserializeObject<GetAllExamsResponse>(contentStr);
                }
            }

            return returnResponse;
        }
    }
}
