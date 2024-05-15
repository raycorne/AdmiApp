namespace AdmiApp.Core.Data
{
    public class Speciality_PassingScoreFree
    {
        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; } = null!;
        public int ScoreFreeId { get; set; }
        public PassingScoreDayFreeFM PassingScoreDayFreeFM { get; set; } = null!;

    }
}
