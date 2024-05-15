namespace AdmiApp.Core.Data
{
    public class University
    {
        public int Id { get; set; }
        public string UniversityName { get; set; } = null!;
        public string UniversityDescription { get; set; } = null!;
        public string UniversityLink { get; set; } = null!;
        public Towns? TownName { get; set; }
        public string Town_name { get; set; } = null!;

        public List<ComissionNumber> ComissionNumber { get; set; } = null!;
        public List<University_Faculty> University_Faculties { get; } = [];
    }
}
