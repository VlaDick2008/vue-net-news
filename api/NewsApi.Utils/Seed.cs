using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using NewsApi.Models;

namespace NewsApi.Utils
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = args.Length > 0 && int.TryParse(args[0], out var n) ? n : 10;
            var items = new List<NewsItem>();
            var rnd = new Random();

            for (int i = 1; i <= count; i++)
            {
                items.Add(
                    new NewsItem
                    {
                        Id = i,
                        Name = $"Mock News Title {i}",
                        Description = $"Description for mock news {i}.",
                        Url = $"https://picsum.photos/seed/news{i}/600/400",
                        PublishedAt = DateTime.UtcNow.AddDays(-rnd.Next(0, 30)),
                    }
                );

                Console.WriteLine("Generated news item" + i);
            }

            var json = JsonSerializer.Serialize(
                items,
                new JsonSerializerOptions { WriteIndented = true }
            );
            var path = Path.Combine("../Data", "news.json");
            File.WriteAllText(path, json);
            Console.WriteLine($"Generated {count} items to {path}");
        }
    }
}
