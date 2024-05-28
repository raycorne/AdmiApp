namespace AdmiApp.Core.Models
{
    public static class APIs
    {
        public const string GetAllExams = "/api/Exams/GetAllExams";
        public const string GetUniversitiesBySubjects = "/api/GetSpecialutyByExam/GetUniversitiesBySubjectsAsync";
        public const string UniversityInfo = "/api/UniversityInfo";
        
        public const string GetUniversitiesByInfo = "/api/UniversitySearch/SearchUniversitiesAsync";
		public const string GetAllUniversitiesNames = "/api/University/GetAllUniversityNames";
		public const string GetAllUniversitiesBySpeciality = "/api/SearchSpeciality/SearchUniversitiesBySpecialityAsync";

		
	}
}
