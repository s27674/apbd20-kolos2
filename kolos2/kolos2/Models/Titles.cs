using System.ComponentModel.DataAnnotations;

namespace kolos2.Models;

public class Titles
{
    [Key]
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    
    public ICollection<CharacterTitles> CharacterTitels { get; set; } = new HashSet<CharacterTitles>();
}

