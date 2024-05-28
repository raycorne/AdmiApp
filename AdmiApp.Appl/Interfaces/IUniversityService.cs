using AdmiApp.Core.DTO;
using AdmiApp.Core.Responses;

namespace AdmiApp.Appl.Interfaces
{
    public interface IUniversityService
    {
        public Task<List<UniversityAdmissionResponseDTO>> GetUniversitiesList(string request);
        public Task<UniversityInfoDTO> GetUniversityInfo(string request);
        public Task<List<UniversityAdmissionResponseDTO>> GetUniversitiesListByName(string name);
        public Task<MainListStringResponse> GetAllUniversitiesNames();
        public Task<List<UniversityAdmissionResponseDTO>> GetUniversitiesListBySpeciality(string speciality);
	}
}
