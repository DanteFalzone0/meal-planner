using System.ComponentModel.DataAnnotations;
namespace MealPlanner; 

public class Ingredient: BaseEntity {
  [Key]
  public string Name { get; set; } = "Unnamed Ingredient";
  /**
   * The available quantity of an ingredient is the number
   * of non-empty containers of that ingredient which are
   * available, with the exception of discretely countable
   * items such as eggs, potatoes, lemons, etc.
   *
   * It is expected that the user should update the database
   * of ingredients whenever a new grocery order is purchased.
   */
  public int AvailableQuantity { get; set; } = 0;
}
