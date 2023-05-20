using Microsoft.AspNetCore.Mvc;
using universidades.Models;
using universidades.Services;

namespace universidades.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UniversityRankingYearController : ControllerBase
{

  IUniversityRankingYearService service;
  public UniversityRankingYearController(IUniversityRankingYearService universityRankingYearService)
  {
    service = universityRankingYearService;
  }

  [HttpPost]
  public async Task<IActionResult> createUniversityRankingYear([FromBody] UniversityRankingYear universityRankingYear)
  {
    await service.create(universityRankingYear);
    return Ok();
  }

  [HttpGet]
  public IActionResult readUniversityRankings()
  {
    return Ok(service.read());
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> updateUniversityRankingYear([FromBody] UniversityRankingYear universityRankingYear, Guid id)
  {
    await service.update(id, universityRankingYear);
    return Ok();
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> deleteUniversityRankingYear(Guid id)
  {
    await service.delete(id);
    return Ok();
  }
}