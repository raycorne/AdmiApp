namespace AdmiApp.Core.Data
{
    public class TrainingPeriod
    {
        public int Id { get; set; }
        public float TrainingPeriodValue { get; set; }
        public List<Speciality> Specialities { get; set; } = null!;
    }
}
