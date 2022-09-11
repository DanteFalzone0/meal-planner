namespace MealPlanner;

public static class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Welcome to Dante's meal planning system.");
    var ui = new UserInterface(new MealDbController(new MealDbContext()));
    ui.DescribeOptions();
    var choice = GetChoice();
    switch (choice) {
      case 0:
        ui.AddNewMealToDb();
      break;
      case 1:
        ui.ViewAllMeals();
      break;
      case 2:
        ui.SelectRandomMeal();
      break;
      case 3:
        ui.GenerateMealPlan();
      break;
      case 4:
        ui.GenerateMealPlanFromIngredients();
      break;
      default:
        Console.WriteLine("Invalid selection. Aborting.");
      break;
    }
    ui.SaveChanges();
  }

  static int GetChoice() {
    try {
      return int.Parse(Console.ReadLine()!);
    } catch (Exception) {
      Console.WriteLine("Invalid selection; please enter a base-10 integer.");
      return GetChoice();
    }
  }
}
