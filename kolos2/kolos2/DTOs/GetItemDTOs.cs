using kolos2.Models;

namespace kolos2.DTOs;

public class GetItemDTOs
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }
    public ICollection<BackpackItemsDTO> BackpackItems { get; set; } = null!; 
    public ICollection<TitleDTO> Titles { get; set; } = null!; 

}

public class TitleDTO
{
    public string title { get; set; }
    public DateTime acquiredAt { get; set; }
    
}

public class BackpackItemsDTO
{
    public string ItemName { get; set; }
    public int ItemWeight { get; set; }
    public int Amount { get; set; }
    
}