using Microsoft.EntityFrameworkCore;
using NekoQOLWebAPI.Entities;

namespace NekoQOLWebAPI.Context;

public class NekoDbContext : DbContext
{

    public DbSet<HypixelPlayer> HypixelPlayers { get; set; }

    public DbSet<Cape> Capes { get; set; }

    public NekoDbContext(DbContextOptions<NekoDbContext> contextOptions) : base(contextOptions)
    {
    }
}
