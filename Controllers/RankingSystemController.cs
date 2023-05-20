using Microsoft.AspNetCore.Mvc;
using universidades.Models;
// using universidades.Services;

namespace universidades.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RankingSystemController : ControllerBase
{
  // IAutorService autorService;
  // public RankingSystemController(IAutorService serviceAutor)
  // {
  //   autorService = serviceAutor;
  // }

  [HttpPost]
  public IActionResult createRankingSystem([FromBody] RankingSystem rankingSystem)
  {
    // autorService.crear(rankingSystem);
    return Ok();
  }

  [HttpGet]
  public IActionResult readRankingSystems()
  {
    // return Ok(autorService.obtener());
    return Ok();
  }

  [HttpPut("{id}")]
  public IActionResult updateRankingSystem([FromBody] RankingSystem rankingSystem, Guid id)
  {
    // autorService.actualizar(id, rankingSystem);
    return Ok();
  }

  [HttpDelete("{id}")]
  public IActionResult deleteRankingSystem(Guid id)
  {
    // autorService.eliminar(id);
    return Ok();
  }
}