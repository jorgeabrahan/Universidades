using universidades.Models;
namespace universidades.Services;

public class RankingSystemService : IRankingSystemService
{
  //Inyeccion de dependencias
  UniversidadesContext context;
  public RankingSystemService(UniversidadesContext dbContext)
  {
    context = dbContext;
  }

  public async Task create(RankingSystem rankingSystem)
  {
    rankingSystem.RankingSystemId = Guid.NewGuid();
    await context.AddAsync(rankingSystem);
    await context.SaveChangesAsync();
  }

  public IEnumerable<RankingSystem>? read()
  {
    return context.RankingSystem;
  }

  public async Task update(Guid id, RankingSystem actualizado)
  {
    var rankingSystem = context.RankingSystem?.Find(id);
    if (rankingSystem == null) return;
    rankingSystem.SystemName = actualizado.SystemName;
    await context.SaveChangesAsync();
  }

  public async Task delete(Guid id)
  {
    var rankingSystem = context.RankingSystem?.Find(id);
    if (rankingSystem == null) return;
    context.Remove(rankingSystem);
    await context.SaveChangesAsync();
  }
}

public interface IRankingSystemService
{
  Task create(RankingSystem rankingSystem);
  IEnumerable<RankingSystem>? read();
  Task update(Guid id, RankingSystem actualizado);
  Task delete(Guid id);
}
