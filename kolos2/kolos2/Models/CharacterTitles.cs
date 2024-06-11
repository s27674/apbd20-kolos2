using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace kolos2.Models;

[Table("Character_titels")]
[PrimaryKey(nameof(CharacterId), nameof(TitelsId))]
public class CharacterTitles
{
    public int CharacterId { get; set; }
    public int TitelsId { get; set; }
    
    public DateTime AcquiredAt { get; set; }
    
    [ForeignKey(nameof(CharacterId))]
    public Characters Character { get; set; } = null!;
    
    [ForeignKey(nameof(TitelsId))]
    public Titles Title { get; set; } = null!;
}