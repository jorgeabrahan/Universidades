using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace universidades.Models;

public class RankingCriteria
{
  [Key]
  public Guid RankingCriteriaId { get; set; }

  [ForeignKey("RankingSystemId")]
  public Guid RankingSystemId { get; set; }

  [Required]
  [MaxLength(250)]
  public String? CriteriaName { get; set; }
}
