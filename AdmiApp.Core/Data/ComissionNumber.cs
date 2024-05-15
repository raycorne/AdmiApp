namespace AdmiApp.Core.Data
{
    public class ComissionNumber
    {
        public int Id { get; set; }
        public string ComissionNumberValue { get; set; } = null!;
        public University? University { get; set; }
        public string UniversityName { get; set; } = null!;
    }
}
