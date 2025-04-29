using NewsApi.Models;

namespace NewsApi.Services;

public class NewsService
{
    private readonly List<NewsItem> _newsItems;

    public NewsService()
    {
        _newsItems = new List<NewsItem>();
    }
}
