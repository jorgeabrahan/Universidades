using System.ComponentModel.DataAnnotations;

namespace universidades.Models;

public class Country
{
  [Key]
  public Guid CountryId { get; set; }

  [Required]
  [MaxLength(250)]
  public String? CountryName { get; set; }
}
