using universidades.Models;
namespace universidades.Services;

public class UniversityRankingYearService : IUniversityRankingYearService
{
  //Inyeccion de dependencias
  UniversidadesContext context;
  public UniversityRankingYearService(UniversidadesContext dbContext)
  {
    context = dbContext;
  }

  public async Task create(UniversityRankingYear universityRankingYear)
  {
    await context.AddAsync(universityRankingYear);
    await context.SaveChangesAsync();
  }

  public IEnumerable<UniversityRankingYear>? read()
  {
    return context.UniversityRankingYear;
  }

  public async Task update(Guid id, UniversityRankingYear actualizado)
  {
    var universityRankingYear = context.UniversityRankingYear?.Find(id);
    if (universityRankingYear == null) return;
    universityRankingYear.Year = actualizado.Year;
    universityRankingYear.Score = actualizado.Score;
    await context.SaveChangesAsync();
  }

  public async Task delete(Guid id)
  {
    var universityRankingYear = context.UniversityRankingYear?.Find(id);
    if (universityRankingYear == null) return;
    context.Remove(universityRankingYear);
    await context.SaveChangesAsync();
  }
}

public interface IUniversityRankingYearService
{
  Task create(UniversityRankingYear universityRankingYear);
  IEnumerable<UniversityRankingYear>? read();
  Task update(Guid id, UniversityRankingYear actualizado);
  Task delete(Guid id);
}
