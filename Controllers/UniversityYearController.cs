using Microsoft.AspNetCore.Mvc;
using universidades.Models;
// using universidades.Services;

namespace universidades.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UniversityYearController : ControllerBase
{

  // IAutorService autorService;
  // public UniversityYearController(IAutorService serviceAutor)
  // {
  //   autorService = serviceAutor;
  // }

  [HttpPost]
  public IActionResult createUniversityYear([FromBody] UniversityYear universityYear)
  {
    // autorService.crear(universityYear);
    return Ok();
  }

  [HttpGet]
  public IActionResult readUniversityYears()
  {
    // return Ok(autorService.obtener());
    return Ok();
  }

  [HttpPut("{id}")]
  public IActionResult updateUniversityYear([FromBody] UniversityYear universityYear, Guid id)
  {
    // autorService.actualizar(id, universityYear);
    return Ok();
  }

  [HttpDelete("{id}")]
  public IActionResult deleteUniversityYear(Guid id)
  {
    // autorService.eliminar(id);
    return Ok();
  }
}