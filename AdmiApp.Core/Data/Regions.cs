namespace AdmiApp.Core.Data
{
    public class Regions
    {
        public int Id { get; set; }
        public string Region { get; set; } = null!;
        public List<Towns> Towns { get; set; } = null!;
    }
}
