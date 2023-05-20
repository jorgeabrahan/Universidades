using Microsoft.AspNetCore.Mvc;
using universidades.Models;
// using universidades.Services;

namespace universidades.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UniversityController : ControllerBase
{

  // IAutorService autorService;
  // public UniversityController(IAutorService serviceAutor)
  // {
  //   autorService = serviceAutor;
  // }

  [HttpPost]
  public IActionResult createUniversity([FromBody] University university)
  {
    // autorService.crear(university);
    return Ok();
  }

  [HttpGet]
  public IActionResult readUniversities()
  {
    // return Ok(autorService.obtener());
    return Ok();
  }

  [HttpPut("{id}")]
  public IActionResult updateUniversity([FromBody] University university, Guid id)
  {
    // autorService.actualizar(id, university);
    return Ok();
  }

  [HttpDelete("{id}")]
  public IActionResult deleteUniversity(Guid id)
  {
    // autorService.eliminar(id);
    return Ok();
  }
}