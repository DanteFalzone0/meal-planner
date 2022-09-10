using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MealPlanner {
  public class Meal: BaseEntity {
    [Key]
    public Guid Id { get; set; } = Guid.Empty;
    public string Name { get; set; } = "Unnamed Meal";
    public string? Recipe { get; set; }
  }
}
