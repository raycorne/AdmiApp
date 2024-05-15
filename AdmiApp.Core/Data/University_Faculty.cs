namespace AdmiApp.Core.Data

{
    public class University_Faculty
    {
        public int UniversityId { get; set; }
        public University University { get; set; } = null!;
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; } = null!;
    }
}
