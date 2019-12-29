using DeepAI;
using System;
using System.IO;
using System.Net;

namespace Colorizer.Console
{
    internal class Program
    {
        private const string ApiKey = "your-api-key-here";

        private static void Main()
        {
            var api = new DeepAI_API(ApiKey);

            var response = api.callStandardApi("colorizer", new { image = File.OpenRead(@"C:\path\to\bw.jpg") });

            using (var webClient = new WebClient())
                webClient.DownloadFile(new Uri(response.output_url), @"C:\path\to\color.jpg");

            // Console.Write(api.objectAsJsonString(resp));
        }
    }
}