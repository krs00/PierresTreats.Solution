using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 

namespace Bakery.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required]
    public string Name { get; set; }
    public List<FlavorTreat> FlavorTreats { get; set; } // JOIN TABLE
    // public ApplicationUser User { get; set; }
  }
}