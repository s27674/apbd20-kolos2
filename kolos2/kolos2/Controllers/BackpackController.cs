using kolos2.Models;
using kolos2.Services;
using Microsoft.AspNetCore.Mvc;

namespace kolos2.Controllers;

public class BackpackController : ControllerBase
{
    private readonly IDbService _dbService;
    public BackpackController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpPost("characters/{characterId}/backpacks")]
    public async Task<IActionResult> AddBackpack([FromBody] Backpacks backpack)
    {
        if (!await _dbService.DoesItemsExist(backpack.ItemId))
            return NotFound($"Backpack with given ID - {backpack.ItemId} doesn't exist");
        if (!await _dbService.DostatecznyAmount(backpack.Amount))
            return NotFound($" {backpack.Amount} nie dostateczny");

        var backpacks = new Backpacks()
        {
            ItemId = backpack.ItemId,
            CharacterId = backpack.CharacterId,
            Amount = backpack.Amount
        };
        return Created("api/backpacks", new
        {
            backpacks.ItemId,
            backpacks.CharacterId,
            backpacks.Amount
        });
    }
}