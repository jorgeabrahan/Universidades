using universidades.Models;
namespace universidades.Services;

public class CountryService : ICountryService
{
  //Inyeccion de dependencias
  UniversidadesContext context;
  public CountryService(UniversidadesContext dbContext)
  {
    context = dbContext;
  }

  public async Task create(Country country)
  {
    country.CountryId = Guid.NewGuid();
    await context.AddAsync<Country>(country);
    await context.SaveChangesAsync();
  }

  public IEnumerable<Country>? read()
  {
    return context.Country;
  }

  public async Task update(Guid id, Country actualizado)
  {
    var country = context.Country?.Find(id);
    if (country == null) return;
    country.CountryName = actualizado.CountryName;
    await context.SaveChangesAsync();
  }

  public async Task delete(Guid id)
  {
    var country = context.Country?.Find(id);
    if (country == null) return;
    context.Remove(country);
    await context.SaveChangesAsync();
  }
}

public interface ICountryService
{
  Task create(Country country);
  IEnumerable<Country>? read();
  Task update(Guid id, Country actualizado);
  Task delete(Guid id);
}
