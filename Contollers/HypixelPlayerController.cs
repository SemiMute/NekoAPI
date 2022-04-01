using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NekoQOLWebAPI.Entities;
using NekoQOLWebAPI.Migrations;
using NekoQOLWebAPI.Repositories;

namespace NekoQOLWebAPI.Controllers;

[Route("api/players")]
[ApiController]
public class HypixelPlayerController : ControllerBase
{

    private readonly IHypixelPlayerRespository _playerRepository;
    public HypixelPlayerController(IHypixelPlayerRespository playerRepository)
    {
        _playerRepository = playerRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<HypixelPlayer>> GetPlayers()
    {
        return await _playerRepository.Get();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<HypixelPlayer>> GetPlayer(Guid id)
    {
        var player = await _playerRepository.GetById(id);

        if (player is null)
        {
            return NotFound();
        }

        return Ok(player);
    }

    [HttpPost("create/")]
    public async Task<ActionResult<HypixelPlayer>> CreatePlayer([FromBody] HypixelPlayer playerDto)
    {
        var newPlayer = await _playerRepository.Create(new HypixelPlayer
        {
            Id = playerDto.Id,
            DisplayName = playerDto.DisplayName,
            Capes = playerDto.Capes
        });
        return CreatedAtAction(nameof(GetPlayers), new { id = newPlayer.Id }, newPlayer);
    }

    [HttpPut("capes/add/{id}")]
    public async Task<ActionResult<HypixelPlayer>> UpdatePlayerCapes(Guid id, [FromBody] Cape cape)
    {
        var player = await _playerRepository.GetById(id);

        if (player is null)
        {
            return NotFound();
        }

        if(player.Capes is null)
        {
            player.Capes = new List<Cape>();
            await _playerRepository.Update(player);
        }

        var Capes = player.Capes;
        Capes.Add(cape);

        player.Capes = Capes;

        await _playerRepository.Update(player);

        return Ok(player);
    }

    [HttpPut("update/displayname/{id}")]
    public async Task<ActionResult<HypixelPlayer>> UpdatePlayerDisplayName(Guid id, [FromBody] HypixelPlayerDisplayNameDto playerDto)
    {
        var player = await _playerRepository.GetById(id);

        if (player is null)
        {
            return NotFound();
        }

        player.DisplayName = playerDto.DisplayName;

        await _playerRepository.Update(player);

        return NoContent();
    }
}
