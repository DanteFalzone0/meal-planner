namespace MealPlanner;

public class BaseEntity {
  public string CreatedBy { get; set; } = "System";
  public string? UpdatedBy { get; set; } = "System";
  public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.Now;
  public DateTimeOffset? UpdatedDate { get; set; } = DateTimeOffset.Now;
}
