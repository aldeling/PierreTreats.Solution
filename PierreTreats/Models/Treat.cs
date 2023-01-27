using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The treat type can't be empty")]
    public string TreatType { get; set; }
    [Required(ErrorMessage = "The treat name can't be empty")]
    public string TreatName { get; set; }
    [Required(ErrorMessage = "The treat rating can't be empty")]
    public string TreatRating { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}