using universidades.Models;
namespace universidades.Services;

public class UniversityService : IUniversityService
{
  //Inyeccion de dependencias
  UniversidadesContext context;
  public UniversityService(UniversidadesContext dbContext)
  {
    context = dbContext;
  }

  public async Task create(University university)
  {
    university.UniversityId = Guid.NewGuid();
    await context.AddAsync(university);
    await context.SaveChangesAsync();
  }

  public IEnumerable<University>? read()
  {
    return context.University;
  }

  public async Task update(Guid id, University actualizado)
  {
    var university = context.University?.Find(id);
    if (university == null) return;
    university.UniversityName = actualizado.UniversityName;
    university.Country = actualizado.Country;
    await context.SaveChangesAsync();
  }

  public async Task delete(Guid id)
  {
    var university = context.University?.Find(id);
    if (university == null) return;
    context.Remove(university);
    await context.SaveChangesAsync();
  }
}

public interface IUniversityService
{
  Task create(University university);
  IEnumerable<University>? read();
  Task update(Guid id, University actualizado);
  Task delete(Guid id);
}
