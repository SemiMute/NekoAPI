using Microsoft.EntityFrameworkCore;
using NekoQOLWebAPI.Context;
using NekoQOLWebAPI.Entities;

namespace NekoQOLWebAPI.Repositories;

public class HypixelPlayerRepository : IHypixelPlayerRespository
{
    private readonly NekoDbContext _context;

    public HypixelPlayerRepository(NekoDbContext context)
    {
        _context = context;
    }
    public async Task<HypixelPlayer> Create(HypixelPlayer player)
    {
        _context.HypixelPlayers.Add(player);
        await _context.SaveChangesAsync();

        return player;
    }

    public async Task Delete(Guid id)
    {
        var playerToDelete = await _context.HypixelPlayers.FindAsync(id);

        if (playerToDelete is null)
        {
            return;
        }

        _context.HypixelPlayers.Remove(playerToDelete);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<HypixelPlayer>> Get()
    {
        return await _context.HypixelPlayers
        .Include(x => x.Capes)
        .ToListAsync();
    }

    public async Task<HypixelPlayer?> GetById(Guid id)
    {
        return await _context.HypixelPlayers
            .Include(x => x.Capes)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task Update(HypixelPlayer player)
    {

         _context.HypixelPlayers.Attach(player);

        _context.Entry(player).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
