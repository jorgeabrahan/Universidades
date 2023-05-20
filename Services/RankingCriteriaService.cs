using universidades.Models;
namespace universidades.Services;

public class RankingCriteriaService : IRankingCriteriaService
{
  //Inyeccion de dependencias
  UniversidadesContext context;
  public RankingCriteriaService(UniversidadesContext dbContext)
  {
    context = dbContext;
  }

  public async Task create(RankingCriteria rankingCriteria)
  {
    rankingCriteria.RankingCriteriaId = Guid.NewGuid();
    await context.AddAsync(rankingCriteria);
    await context.SaveChangesAsync();
  }

  public IEnumerable<RankingCriteria>? read()
  {
    return context.RankingCriteria;
  }

  public async Task update(Guid id, RankingCriteria actualizado)
  {
    var rankingCriteria = context.RankingCriteria?.Find(id);
    if (rankingCriteria == null) return;
    rankingCriteria.CriteriaName = actualizado.CriteriaName;
    await context.SaveChangesAsync();
  }

  public async Task delete(Guid id)
  {
    var rankingCriteria = context.RankingCriteria?.Find(id);
    if (rankingCriteria == null) return;
    context.Remove(rankingCriteria);
    await context.SaveChangesAsync();
  }
}

public interface IRankingCriteriaService
{
  Task create(RankingCriteria rankingCriteria);
  IEnumerable<RankingCriteria>? read();
  Task update(Guid id, RankingCriteria actualizado);
  Task delete(Guid id);
}
