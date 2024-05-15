namespace AdmiApp.Core.Data
{
    public class Exams
    {
        public int Id { get; set; }
        public string Exams_Name { get; set; } = null!;
        public List<Speciality_Exams>? Speciality_Exams { get; } = [];
    }
}
