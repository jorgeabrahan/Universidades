using System.ComponentModel.DataAnnotations;

namespace universidades.Models;

public class RankingSystem
{
  [Key]
  public Guid RankingSystemId { get; set; }

  [Required]
  [MaxLength(250)]
  public String? SystemName { get; set; }
}
