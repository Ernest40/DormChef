namespace DormChef.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string PrepTime { get; set; } = string.Empty;

        public List<string> Ingredients { get; set; } = new();
        public List<string> Steps { get; set; } = new();
    }
}