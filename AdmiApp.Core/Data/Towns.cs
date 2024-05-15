namespace AdmiApp.Core.Data
{
    public class Towns
    {
        public int Id { get; set; }
        public string StreetName { get; set; } = null!;
        public string TownName { get; set; } = null!;
        public Regions? RegionsName { get; set; }
        public string Regions_Name { get; set; } = null!;
        public List<University> Universities { get; set; } = null!;
    }
}
