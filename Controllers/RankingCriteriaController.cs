using Microsoft.AspNetCore.Mvc;
using universidades.Models;
// using universidades.Services;

namespace universidades.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RankingCriteriaController : ControllerBase
{
  // IAutorService autorService;
  // public RankingCriteriaController(IAutorService serviceAutor)
  // {
  //   autorService = serviceAutor;
  // }

  [HttpPost]
  public IActionResult createRankingCriteria([FromBody] RankingCriteria rankingCriteria)
  {
    // autorService.crear(rankingCriteria);
    return Ok();
  }

  [HttpGet]
  public IActionResult readRankingCriterias()
  {
    // return Ok(autorService.obtener());
    return Ok();
  }

  [HttpPut("{id}")]
  public IActionResult updateRankingCriteria([FromBody] RankingCriteria rankingCriteria, Guid id)
  {
    // autorService.actualizar(id, rankingCriteria);
    return Ok();
  }

  [HttpDelete("{id}")]
  public IActionResult deleteRankingCriteria(Guid id)
  {
    // autorService.eliminar(id);
    return Ok();
  }
}