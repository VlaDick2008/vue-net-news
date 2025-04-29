using System.Text.Json;
using NewsApi.Models;

namespace NewsApi.Services;

public class NewsService
{
    private readonly List<NewsItem> _newsItems;

    public NewsService()
    {
        var json = File.ReadAllText(Path.Combine("../api/Data", "news.json"));
        _newsItems = JsonSerializer.Deserialize<List<NewsItem>>(json)!;
    }

    public IEnumerable<NewsItem> GetAll(string? query = null)
    {
        return string.IsNullOrEmpty(query)
            ? _newsItems
            : _newsItems.Where(x => x.Name.Contains(query, StringComparison.OrdinalIgnoreCase));
    }
}
