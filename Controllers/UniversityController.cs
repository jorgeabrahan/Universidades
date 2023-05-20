using Microsoft.AspNetCore.Mvc;
using universidades.Models;
using universidades.Services;

namespace universidades.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UniversityController : ControllerBase
{

  IUniversityService service;
  public UniversityController(IUniversityService universityService)
  {
    service = universityService;
  }

  [HttpPost]
  public async Task<IActionResult> createUniversity([FromBody] University university)
  {
    await service.create(university);
    return Ok();
  }

  [HttpGet]
  public IActionResult readUniversities()
  {
    return Ok(service.read());
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> updateUniversity([FromBody] University university, Guid id)
  {
    await service.update(id, university);
    return Ok();
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> deleteUniversity(Guid id)
  {
    await service.delete(id);
    return Ok();
  }
}