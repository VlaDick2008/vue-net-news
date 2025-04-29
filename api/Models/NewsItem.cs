namespace NewsApi.Models;

public class NewsItem {
  public int Id { get; set; }
  public string Name { get; set; } = "";
  public string Description { get; set; } = "";
  public string Url { get; set; } = "";
  public string ImageUrl { get; set; } = "";
  public DateTime PublishedAt { get; set; }
}