namespace AdmiApp.Core.Data
{
    public class Speciality
    {
        public int Id { get; set; }
        public string SpecialityName { get; set; } = null!;
        public TrainingPeriod? TrainingPeriod { get; set; }
        public float Trainin_Period { get; set; }
        public List<Speciality_Faculty>? Speciality_Faculties { get; } = [];
        public List<Speciality_Exams>? Speciality_Exams { get; } = [];
        public List<Speciality_PassingScoreFree>? Speciality_PassingScoreFrees { get; } = [];
    }
}
