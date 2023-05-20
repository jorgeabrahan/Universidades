using Microsoft.AspNetCore.Mvc;
using universidades.Models;
// using universidades.Services;

namespace universidades.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CountryController : ControllerBase
{

  // IAutorService autorService;
  // public CountryController(IAutorService serviceAutor)
  // {
  //   autorService = serviceAutor;
  // }

  [HttpPost]
  public IActionResult createCountry([FromBody] Country country)
  {
    // autorService.crear(country);
    return Ok();
  }

  [HttpGet]
  public IActionResult readCountries()
  {
    // return Ok(autorService.obtener());
    return Ok();
  }

  [HttpPut("{id}")]
  public IActionResult updateCountry([FromBody] Country country, Guid id)
  {
    // autorService.actualizar(id, country);
    return Ok();
  }

  [HttpDelete("{id}")]
  public IActionResult deleteCountry(Guid id)
  {
    // autorService.eliminar(id);
    return Ok();
  }
}