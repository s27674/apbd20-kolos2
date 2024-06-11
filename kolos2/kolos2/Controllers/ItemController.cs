using kolos2.DTOs;
using kolos2.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace kolos2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemController : ControllerBase
{
    private readonly IDbService _dbService;
    public ItemController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("characters/{characterId}")]
    public async Task<IActionResult> GetCharacterData(int characterId)
    {
        var orders = await _dbService.GetCharacterData(characterId);

        return Ok(orders.Select(e => new GetItemDTOs()
        {
            FirstName = e.FirstName,
            LastName = e.LastName,
            CurrentWeight = e.CurrentWeight,
            MaxWeight = e.MaxWeight,
            BackpackItems = e.Backpack.Select(p => new BackpackItemsDTO
            {
                ItemName = p.Item.Name,
                ItemWeight = p.Item.Weight,
                Amount = p.Amount
            }).ToList(),
            Titles = e.CharacterTitels.Select(e => new TitleDTO
            {
                title = e.Title.Name,
                acquiredAt = DateTime.Parse("2002-04-13")
            }).ToList()
        }));

    }
}