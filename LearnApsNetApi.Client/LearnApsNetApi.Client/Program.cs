using LearnApsNetApi.Common.Models;
using System;
using System.Net.Http;

namespace LearnApsNetApi.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:57119") })
            {
                HttpResponseMessage response = httpClient.GetAsync("api/products/1").Result;

                if (response.IsSuccessStatusCode)
                {
                    Product product = response.Content.ReadAsAsync<Product>().Result;
                    Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);
                }
            };

            var line = Console.ReadLine();
        }
    }
}
