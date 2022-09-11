namespace MealPlanner;

public class MealDbController {
  private MealDbContext DbContext;
  public MealDbController(MealDbContext dbContext) { this.DbContext = dbContext; }
  public void AddNewIngredient(Ingredient ingredient) {
    Console.WriteLine($"Added new ingredient {ingredient.Name} to database.");
  }

  public void AddMeal(Meal meal) {
    Console.WriteLine($"Added new meal {meal.Name} to database.");
  }
}
