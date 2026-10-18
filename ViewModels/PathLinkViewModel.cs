using Treasure_Hunt.Models;
using Path = Treasure_Hunt.Models.Path;
namespace Treasure_Hunt.ViewModels;

// View model for the repeated PathLinkView partial view to be rendered in each view
public class PathLinkViewModel
{
    public required Path Path { get; set; }
    public bool HasShovel { get; set; }
    public int Moves { get; set; }
}