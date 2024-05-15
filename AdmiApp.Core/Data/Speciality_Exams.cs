namespace AdmiApp.Core.Data
{
    public class Speciality_Exams
    {
        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; } = null!;
        public int ExamsId { get; set; }
        public Exams Exams { get; set; } = null!;

    }
}
