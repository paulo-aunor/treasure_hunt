using Microsoft.AspNetCore.Mvc;
using Treasure_Hunt.Data;
using Treasure_Hunt.Models;
using Treasure_Hunt.ViewModels;

namespace Treasure_Hunt.Controllers;

public class HuntController : Controller
{
    private readonly ILocationRepository _locationRepository;

    //initialization of the controller
    public HuntController(ILocationRepository locationRepository)
    {
        _locationRepository = locationRepository;
    }
    
    //method to show the view based on the targetLocationId given
    //hasShovel and moves are set to false and 0 as you dont have 
    //a shovel and number of moves on the first move
    [HttpGet("/location/{id}")]
    public IActionResult Show(int id, bool hasShovel = false, int moves = 0)
    {
        var location = _locationRepository.GetLocationById(id);
        if (location is null) return NotFound();
        
        //if the player has the shovel and is in the treasure location
        //handle the display of the win view
        if (location.IsTreasure && hasShovel)
        {
            return View("Win", new LocationViewModel
            {
                Location = location,
                HasShovel = hasShovel,
                Moves = moves
            });
        }

        return View(new LocationViewModel
        {
            Location = location,
            HasShovel = hasShovel,
            Moves = moves,
        });
    }
    
    //home page is set to the first location
    [HttpGet("/")]
    public IActionResult Start() => RedirectToAction(nameof(Show), new { id = 1 });

}