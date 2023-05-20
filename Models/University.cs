using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace universidades.Models;

public class University
{
  [Key]
  public Guid UniversityId { get; set; }

  [ForeignKey("CountryId")]
  public Guid CountryId { get; set; }

  [Required]
  [MaxLength(250)]
  public String? UniversityName { get; set; }

  public virtual Country? Country { get; set; }
}
