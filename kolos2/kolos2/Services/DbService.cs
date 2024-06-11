using kolos2.Data;
using kolos2.Models;
using Microsoft.EntityFrameworkCore;

namespace kolos2.Services;

public class DbService : IDbService
{
    private readonly ItemsContext _context;
    public DbService(ItemsContext context)
    {
        _context = context;
    }
    public async Task<ICollection<Characters>> GetCharacterData(int characterId)
    {
        return await _context.Character
            .Include(e => e.Backpack)
            .ThenInclude(e => e.Item)
            .Include(e => e.CharacterTitels)
            .ThenInclude(e => e.Title)
            .Where(e => e.Id == characterId)
            .ToListAsync();
    }

    public async Task<bool> DoesItemsExist(int itemId)
    {
        return await _context.Item.AnyAsync(e => e.IdItems == itemId);
    }
    
    public async Task<bool> DostatecznyAmount(int amount)
    {
        return await _context.Backpack.AnyAsync(e => e.Amount == amount);
    }
    
    public async Task AddBackpack(IEnumerable<Backpacks> backpacks)
    {
        await _context.AddRangeAsync(backpacks);
        await _context.SaveChangesAsync();
    }
}