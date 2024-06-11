using System.ComponentModel.DataAnnotations;

namespace kolos2.Models;

public class Characters
{
    [Key] 
    public int Id { get; set; }

    [MaxLength(50)] public string FirstName { get; set; } = string.Empty;

    [MaxLength(120)] public string LastName { get; set; } = string.Empty;

    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }

    public ICollection<Backpacks> Backpack { get; set; } = new HashSet<Backpacks>();
    public ICollection<CharacterTitles> CharacterTitels { get; set; } = new HashSet<CharacterTitles>();
}