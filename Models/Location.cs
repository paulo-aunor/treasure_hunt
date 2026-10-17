namespace Treasure_Hunt.Models;

public class Location
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public bool HasShovel { get; set; }
    public bool IsTreasure { get; set; }
    public List<Path> Paths { get; set; } = new();
}