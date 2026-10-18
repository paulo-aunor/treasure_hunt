using Treasure_Hunt.Models;
namespace Treasure_Hunt.ViewModels;

//ViewModel for Location to get the Location Object, HasShovel and Number of Moves
//for the currently rendered View to read
public class LocationViewModel
{
    public required Location Location { get; set; }
    public bool HasShovel { get; set; }
    public int Moves { get; set; }
}