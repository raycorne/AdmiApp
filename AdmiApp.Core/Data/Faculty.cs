namespace AdmiApp.Core.Data
{
    public class Faculty
    {
        public int Id { get; set; }
        public string FacultyName { get; set; } = null!;
        public List<University_Faculty>? University_Faculties { get; } = [];
        public List<Speciality_Faculty>? Speciality_Faculties { get; } = [];
    }
}
