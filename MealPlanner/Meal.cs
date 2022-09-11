using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace MealPlanner;

public class Meal: BaseEntity {
  //public Guid Id { get; set; } = Guid.Empty;
  [Key]
  public string Name { get; set; } = "Unnamed Meal";
  public string? Recipe { get; set; }
  public List<Ingredient>? Ingredients { get; set; }
}
