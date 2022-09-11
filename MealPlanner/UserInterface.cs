namespace MealPlanner; 

public class UserInterface {
  private MealDbController Database;
  public UserInterface(MealDbController database) { this.Database = database; }
  public void DescribeOptions() {
    Console.WriteLine(
      "Choose an option to continue:\n" +
      "0: Add a new meal to the database of meals.\n" +
      "1: View all meals in the database.\n" +
      "2: Select a random meal from the database.\n" +
      "3: Generate a meal plan and a grocery list for it.\n" +
      "4: Generate a meal plan given a list of ingredients."
    );
  }
  public void AddNewMealToDb() {
    Console.WriteLine(
      "What ingredients are needed to make this meal?\n" +
      "Type in their names in all lowercase separated by semicolons."
    );
    Console.Write("Ingredients: ");
    var ingredientString = Console.ReadLine()!;
    var ingredientNames = ingredientString.Split(";");
    var meal = new Meal { Ingredients = new List<Ingredient>() };
    foreach (string ingredientName in ingredientNames) {
      var ingredient = new Ingredient { Name = ingredientName };
      meal.Ingredients.Add(ingredient);
      this.Database.AddNewIngredient(ingredient);
    }
    Console.WriteLine("And what is the name of the meal itself?");
    Console.Write("Name of the meal: ");
    meal.Name = Console.ReadLine()!;
    Console.Write("Would you like to attach a recipe to this meal? y/n ");
    var choice = Console.ReadLine()!;
    if (choice.ToLower()[0] != 'n') {
      Console.WriteLine("Start typing in a recipe. Press Ctrl+D when finished.");
      var recipe = string.Empty;
      string? line;
      while ((line = Console.ReadLine()) != null) {
        recipe += line + "\n";
      }
      meal.Recipe = recipe;
    }
    this.Database.AddMeal(meal);
  }
  
  public void ViewAllMeals() { Console.WriteLine("unimplemented"); }
  public void SelectRandomMeal() { Console.WriteLine("unimplemented"); }
  public void GenerateMealPlan() { Console.WriteLine("unimplemented"); }
  public void GenerateMealPlanFromIngredients() { Console.WriteLine("unimplemented"); }
  public void SaveChanges() {}
}
