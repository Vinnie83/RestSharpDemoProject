using RestSharp;
using System.Text.Json;

namespace RestSharpDemoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://api.github.com");

            RestRequest request = new RestRequest("repos/Vinnie83/postman/issues/1", Method.Get);

            var response = client.Execute(request);

            Console.WriteLine("STATUS CODE: " + response.StatusCode);

            var issue = JsonSerializer.Deserialize<Issue>(response.Content);
            

            Console.WriteLine("Issue Title: " + issue.name);
            Console.WriteLine("Issue number: " + issue.number);
                   
        }
    }
}