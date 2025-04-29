using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using LoremNET;
using Microsoft.AspNetCore.Mvc.Routing;
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

            var imageRand = new[]
            {
                "",
                "neo/",
                "millie/",
                "millie_neo/",
                "neo_banana/",
                "neo_2/",
                "bella/",
            };

            int nameCount = rnd.Next(5, 20);
            int descriptionCount = rnd.Next(25, 155);

            for (int i = 1; i <= count; i++)
            {
                int imageIndex = rnd.Next(imageRand.Length);

                items.Add(
                    new NewsItem
                    {
                        Id = i,
                        Name = Lorem.Words(nameCount),
                        Description = Lorem.Words(descriptionCount),
                        Url = $"https://placecats.com/{imageRand[imageIndex]}600/400",
                        ImageUrl = $"https://placecats.com/{imageRand[imageIndex]}600/400",
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
