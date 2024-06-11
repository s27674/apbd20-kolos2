using kolos2.Models;
using Microsoft.EntityFrameworkCore;

namespace kolos2.Data;

public class ItemsContext : DbContext
{
    protected ItemsContext()
    {
    }

    public ItemsContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Backpacks> Backpack { get; set; }
    public DbSet<Characters> Character { get; set; }
    public DbSet<CharacterTitles> CharacterTitle { get; set; }
    public DbSet<Items> Item { get; set; }
    public DbSet<Titles> Title { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Backpacks>().HasData(new List<Backpacks>
        {
            new Backpacks
            {
                CharacterId = 1,
                ItemId = 1,
                Amount = 11
            },
            new Backpacks
            {
                CharacterId = 2,
                ItemId = 2,
                Amount = 22
            }
        });

        modelBuilder.Entity<Characters>().HasData(new List<Characters>
        {
            new Characters
            {
                Id = 1,
                FirstName = "FirstName1",
                LastName = "LastName1",
                CurrentWeight = 14,
                MaxWeight = 40
            },
            new Characters
            {
                Id = 2,
                FirstName = "FirstName2",
                LastName = "LastName12",
                CurrentWeight = 15,
                MaxWeight = 50
            }
        });
        modelBuilder.Entity<CharacterTitles>().HasData(new List<CharacterTitles>
        {
            new CharacterTitles
            {
                CharacterId = 1,
                TitelsId = 1,
                AcquiredAt = DateTime.Parse("2022-12-30")
            },
            new CharacterTitles
            {
                CharacterId = 2,
                TitelsId = 2,
                AcquiredAt = DateTime.Parse("2021-02-14")
            }
        });
        modelBuilder.Entity<Items>().HasData(new List<Items>
        {
            new Items
            {
                IdItems = 1,
                Name = "ItemName1",
                Weight  = 33
            },
            new Items
            {
                IdItems = 2,
                Name = "ItemName2",
                Weight = 22
            }
        });
        modelBuilder.Entity<Titles>().HasData(new List<Titles>
        {
            new Titles
            {
                Id = 1,
                Name = "TitlesName1",
            },
            new Titles
            {
                Id = 2,
                Name = "TitlesName2",
            }
        });
    }
}