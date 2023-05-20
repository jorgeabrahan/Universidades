using Microsoft.AspNetCore.Mvc;
using universidades.Models;
using universidades.Services;

namespace universidades.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CountryController : ControllerBase
{

  ICountryService service;
  public CountryController(ICountryService countryService)
  {
    service = countryService;
  }

  [HttpPost]
  public async Task<IActionResult> createCountry([FromBody] Country country)
  {
    await service.create(country);
    return Ok();
  }

  [HttpGet]
  public IActionResult readCountries()
  {
    return Ok(service.read());
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> updateCountry([FromBody] Country country, Guid id)
  {
    await service.update(id, country);
    return Ok();
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> deleteCountry(Guid id)
  {
    await service.delete(id);
    return Ok();
  }
}