using Microsoft.AspNetCore.Mvc;
using universidades.Models;
using universidades.Services;

namespace universidades.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RankingCriteriaController : ControllerBase
{
  RankingCriteriaService service;
  public RankingCriteriaController(RankingCriteriaService rankingCriteriaService)
  {
    service = rankingCriteriaService;
  }

  [HttpPost]
  public async Task<IActionResult> createRankingCriteria([FromBody] RankingCriteria rankingCriteria)
  {
    await service.create(rankingCriteria);
    return Ok();
  }

  [HttpGet]
  public IActionResult readRankingCriterias()
  {
    return Ok(service.read());
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> updateRankingCriteria([FromBody] RankingCriteria rankingCriteria, Guid id)
  {
    await service.update(id, rankingCriteria);
    return Ok();
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> deleteRankingCriteria(Guid id)
  {
    await service.delete(id);
    return Ok();
  }
}