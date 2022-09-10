using System.Runtime.CompilerServices;

namespace MealPlanner {
  public static class Program {
    public static void Main(string[] args) {
      Console.WriteLine("Welcome to Dante's meal planning system.");
      var dbContext = new MealDbContext();
      DescribeOptions();
      int choice = GetChoice();
      switch (choice) {
        case 0:
          AddNewMealToDb(dbContext);
        break;
        case 1:
          ViewAllMeals(dbContext);
        break;
        case 2:
          SelectRandomMeal(dbContext);
        break;
        case 3:
          GenerateMealPlan(dbContext);
        break;
        case 4:
          GenerateMealPlanFromIngredients(dbContext);
        break;
        default:
          Console.WriteLine("Invalid selection. Aborting.");
        break;
      }
      dbContext.SaveChanges();
    }

    private static void DescribeOptions() {
      Console.WriteLine(
        "Choose an option to continue:\n" +
        "0: Add a new meal to the database of meals.\n" +
        "1: View all meals in the database.\n" +
        "2: Select a random meal from the database.\n" +
        "3: Generate a meal plan and a grocery list for it.\n" +
        "4: Generate a meal plan given a list of ingredients."
      );
    }

    private static int GetChoice() {
      try {
        return int.Parse(Console.ReadLine()!);
      } catch (Exception ex) {
        Console.WriteLine("Invalid selection; please enter a base-10 integer.");
        return GetChoice();
      }
    }
    
    // TODO
    private static void AddNewMealToDb(MealDbContext dbContext) {}
    private static void ViewAllMeals(MealDbContext dbContext) {}
    private static void SelectRandomMeal(MealDbContext dbContext) {}
    private static void GenerateMealPlan(MealDbContext dbContext) {}
    private static void GenerateMealPlanFromIngredients(MealDbContext dbContext) {}
  }
}
