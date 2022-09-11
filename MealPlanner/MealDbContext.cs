using Microsoft.EntityFrameworkCore;
namespace MealPlanner;

public class MealDbContext: DbContext {
  public DbSet<Meal>? Meals { get; set; }
  public DbSet<Ingredient>? Ingredients { get; set; }
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
    optionsBuilder.UseMySql(
      "server=localhost;port=3306;database=meal_db;user=dfalzone;password=admin;",
      new MySqlServerVersion(new Version(8, 0, 11))
    );
  }
}
