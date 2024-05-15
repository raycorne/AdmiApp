namespace AdmiApp.Core.DTO
{
    public class NewFacultyDTO
    {
        public string FacultyName { get; set; } = null!;
        public List<NewSpecialityDTO> Specialties { get; set; } = null!;
    }
}
