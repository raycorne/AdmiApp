namespace AdmiApp.Core.Data
{
    public class Speciality_Faculty
    {
        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; } = null!;
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; } = null!;

    }
}
