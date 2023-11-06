using RestSharp;
using System.Text.Json;

namespace RestSharpDemoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://api.github.com");

            RestRequest request = new RestRequest("repos/Vinnie83/postman/issues", Method.Get);

            var response = client.Execute(request);

            Console.WriteLine("STATUS CODE: " + response.StatusCode);

            var issues = JsonSerializer.Deserialize<List<Issue>>(response.Content);
            


            foreach (var issue in issues)
            {
                Console.WriteLine("Issue Title: " + issue.title);
                Console.WriteLine("Issue number: " + issue.number);
            }
        }
    }
}