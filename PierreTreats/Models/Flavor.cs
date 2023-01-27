using System.Collections.Generic;

namespace PierreTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set;}
    [Required(ErrorMessage = "The flavor type can't be empty")]
    public string FlavorType { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
  }
}