using kolos2.Models;

namespace kolos2.Services;

public interface IDbService
{
    Task<ICollection<Characters>> GetCharacterData(int characterId);
    Task<bool> DoesItemsExist(int itemId);

    Task<bool> DostatecznyAmount(int amount);
    Task AddBackpack(IEnumerable<Backpacks> backpacks);
}