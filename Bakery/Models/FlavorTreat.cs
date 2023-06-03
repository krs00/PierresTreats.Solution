using System.Collections.Generic;
namespace Factory.Models
{
  public class FlavorTreat
  {
    public int FlavorTreatId { get; set; } // Primary Key

    public int FlavorId { get; set; } // Foreign Key
    public Flavor Flavor { get; set; } // Reference Navigation Property

    public int TreatId { get; set; } // Foreign Key
    public Treat Treat { get; set; } // Reference Navigation Property
  }
}