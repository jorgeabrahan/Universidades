using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace universidades.Models;

public class UniversityRankingYear
{
  [ForeignKey("UniversityId")]
  public Guid UniversityId { get; set; }

  [ForeignKey("RankingCriteriaId")]
  public Guid RankingCriteriaId { get; set; }

  [Required]
  public int Year { get; set; }

  [Required]
  public int Score { get; set; }

  public virtual University? University { get; set; }
  public virtual RankingCriteria? RankingCriteria { get; set; }
}
