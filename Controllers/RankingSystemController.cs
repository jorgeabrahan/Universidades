using Microsoft.AspNetCore.Mvc;
using universidades.Models;
using universidades.Services;

namespace universidades.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RankingSystemController : ControllerBase
{
  IRankingSystemService service;
  public RankingSystemController(IRankingSystemService rankingSystemService)
  {
    service = rankingSystemService;
  }

  [HttpPost]
  public async Task<IActionResult> createRankingSystem([FromBody] RankingSystem rankingSystem)
  {
    await service.create(rankingSystem);
    return Ok();
  }

  [HttpGet]
  public IActionResult readRankingSystems()
  {
    return Ok(service.read());
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> updateRankingSystem([FromBody] RankingSystem rankingSystem, Guid id)
  {
    await service.update(id, rankingSystem);
    return Ok();
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> deleteRankingSystem(Guid id)
  {
    await service.delete(id);
    return Ok();
  }
}