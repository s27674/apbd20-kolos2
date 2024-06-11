using System.ComponentModel.DataAnnotations;

namespace kolos2.Models;

public class Items
{
    [Key]
    public int IdItems { get; set; }

    [MaxLength(100)] public string Name { get; set; } = string.Empty;
    public int Weight { get; set; }
    
    public ICollection<Backpacks> Backpack { get; set; } = new HashSet<Backpacks>();
}