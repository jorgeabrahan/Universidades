using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace universidades.Models;

public class UniversityYear
{
  [ForeignKey("UniversityId")]
  public Guid UniversityId { get; set; }

  [Required]
  public int Year { get; set; }

  [Required]
  public int NumStudents { get; set; }

  [Required]
  public int StudentStaffRatio { get; set; }

  [Required]
  public int PctInternationalStudents { get; set; }

  [Required]
  public int PctFemaleStudents { get; set; }

  public virtual University? University { get; set; }
}
