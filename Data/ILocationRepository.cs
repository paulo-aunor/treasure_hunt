using Treasure_Hunt.Models;
namespace Treasure_Hunt.Data;

public interface ILocationRepository
{
    Location? GetLocationById(int locationId);
    List<Location> GetAllLocations();
}