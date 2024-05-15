namespace AdmiApp.Core.Data
{
    public class PassingScoreDayFreeFM
    {
        public int ScoreFreeId { get; set; }
        public int PassingScoreValueDayFree { get; set; }
        public int PassingScoreValueDayForMoney { get; set; }
        public List<Speciality_PassingScoreFree>? Speciality_PassingScoreFrees { get; } = [];
    }
}
