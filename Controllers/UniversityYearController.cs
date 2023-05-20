using Microsoft.AspNetCore.Mvc;
using universidades.Models;
using universidades.Services;

namespace universidades.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UniversityYearController : ControllerBase
{

  IUniversityYearService service;
  public UniversityYearController(IUniversityYearService universityYearService)
  {
    service = universityYearService;
  }

  [HttpPost]
  public async Task<IActionResult> createUniversityYear([FromBody] UniversityYear universityYear)
  {
    await service.create(universityYear);
    return Ok();
  }

  [HttpGet]
  public IActionResult readUniversityYears()
  {
    return Ok(service.read());
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> updateUniversityYear([FromBody] UniversityYear universityYear, Guid id)
  {
    await service.update(id, universityYear);
    return Ok();
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> deleteUniversityYear(Guid id)
  {
    await service.delete(id);
    return Ok();
  }
}