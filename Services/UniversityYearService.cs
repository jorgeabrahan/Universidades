using universidades.Models;
namespace universidades.Services;

public class UniversityYearService : IUniversityYearService
{
  //Inyeccion de dependencias
  UniversidadesContext context;
  public UniversityYearService(UniversidadesContext dbContext)
  {
    context = dbContext;
  }

  public async Task create(UniversityYear universityYear)
  {
    await context.AddAsync(universityYear);
    await context.SaveChangesAsync();
  }

  public IEnumerable<UniversityYear>? read()
  {
    return context.UniversityYear;
  }

  public async Task update(Guid id, UniversityYear actualizado)
  {
    var universityYear = context.UniversityYear?.Find(id);
    if (universityYear == null) return;
    universityYear.Year = actualizado.Year;
    universityYear.NumStudents = actualizado.NumStudents;
    universityYear.StudentStaffRatio = actualizado.StudentStaffRatio;
    universityYear.PctInternationalStudents = actualizado.PctInternationalStudents;
    universityYear.PctFemaleStudents = actualizado.PctFemaleStudents;
    await context.SaveChangesAsync();
  }

  public async Task delete(Guid id)
  {
    var universityYear = context.UniversityYear?.Find(id);
    if (universityYear == null) return;
    context.Remove(universityYear);
    await context.SaveChangesAsync();
  }
}

public interface IUniversityYearService
{
  Task create(UniversityYear universityYear);
  IEnumerable<UniversityYear>? read();
  Task update(Guid id, UniversityYear actualizado);
  Task delete(Guid id);
}
