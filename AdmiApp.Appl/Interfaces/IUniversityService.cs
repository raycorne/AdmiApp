using AdmiApp.Core.DTO;

namespace AdmiApp.Appl.Interfaces
{
    public interface IUniversityService
    {
        public Task<List<UniversityAdmissionResponseDTO>> GetUniversitiesList(string request);
        public Task<UniversityInfoDTO> GetUniversityInfo(string request);
    }
}
