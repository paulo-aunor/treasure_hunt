using Treasure_Hunt.Models;
using Path = Treasure_Hunt.Models.Path;

namespace Treasure_Hunt.Data;

public class LocationRepository : ILocationRepository
{
    private readonly List<Location> _locations = new()
    {
        new Location
        {
            Id = 1,
            Name = "Port",
            Description = "Port where you start off the treasure hunt",
            ImageUrl = "",
            HasShovel = false,
            IsTreasure = false,
            Paths = new List<Path>()
            {
                new Path{Label = "To Jungle", TargetLocationId = 2},
                new Path{Label = "To Mountain", TargetLocationId = 4},
            }
        },
        new Location
        {
            Id = 2,
            Name = "Jungle",
            Description = "Jungle area filled with animals and trees",
            ImageUrl = "",
            HasShovel = false,
            IsTreasure = false,
            Paths = new List<Path>()
            {
                new Path{Label = "To Port", TargetLocationId = 1},
                new Path{Label = "To Cave", TargetLocationId = 3},
                new Path{Label = "To Mountain",  TargetLocationId = 4},
                new Path{Label = "To River",  TargetLocationId = 5},
            }
        },
        new Location
        {
            Id = 3,
            Name = "Cave",
            Description = "Limestone cave area",
            ImageUrl = "",
            HasShovel = false,
            IsTreasure = true,
            Paths = new List<Path>()
            {
                new Path{Label = "To Port",  TargetLocationId = 1},
            }
        },
        new Location
        {
            Id = 4,
            Name = "Mountain",
            Description = "Mountain area with the highest view of the whole island",
            ImageUrl = "",
            HasShovel = true,
            IsTreasure = false,
            Paths = new List<Path>()
            {
                new Path{Label = "To Jungle", TargetLocationId = 2},
                new Path{Label = "To River", TargetLocationId = 5},
                new Path{Label = "To Ruins", TargetLocationId = 6}
            }
        },
        new Location
        {
            Id = 5,
            Name = "River",
            ImageUrl = "",
            HasShovel = false,
            IsTreasure = false,
            Paths = new List<Path>()
            {
                new Path{Label = "To Mountain",  TargetLocationId = 4},
                new Path{Label = "To Jungle", TargetLocationId = 2},
                new Path{Label = "To Ruins", TargetLocationId = 6},
            }
        },
        new Location
        {
            Id = 6,
            Name = "Ruins",
            ImageUrl = "",
            HasShovel = false,
            IsTreasure = false,
            Paths = new List<Path>()
            {
                new Path{Label = "To Mountain", TargetLocationId = 4},
                new Path{Label = "To Jungle", TargetLocationId = 2},
            }
        }
    };
    
    //implementation for GetLocationById from ILocationRepository
    public Location? GetLocationById(int locationId)
    {
        return _locations.FirstOrDefault(location => location.Id == locationId);
    }
    
    //implementation for GetAllLcations from ILocationRepository
    public List<Location> GetAllLocations()
    {
        return _locations;
    }
}