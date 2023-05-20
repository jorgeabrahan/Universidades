using Microsoft.AspNetCore.Mvc;
using universidades.Models;
// using universidades.Services;

namespace universidades.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UniversityRankingYearController : ControllerBase
{

  // IAutorService autorService;
  // public UniversityRankingYearController(IAutorService serviceAutor)
  // {
  //   autorService = serviceAutor;
  // }

  [HttpPost]
  public IActionResult createUniversityRankingYear([FromBody] UniversityRankingYear universityRankingYear)
  {
    // autorService.crear(universityRankingYear);
    return Ok();
  }

  [HttpGet]
  public IActionResult readUniversityRankings()
  {
    // return Ok(autorService.obtener());
    return Ok();
  }

  [HttpPut("{id}")]
  public IActionResult updateUniversityRankingYear([FromBody] UniversityRankingYear universityRankingYear, Guid id)
  {
    // autorService.actualizar(id, universityRankingYear);
    return Ok();
  }

  [HttpDelete("{id}")]
  public IActionResult deleteUniversityRankingYear(Guid id)
  {
    // autorService.eliminar(id);
    return Ok();
  }
}