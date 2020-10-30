using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace csharp_playground
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     ExecuteSync();
        // }

        static async Task Main(string[] args)
        {
            await ExecuteAsync();
        }

        static void ExecuteSync()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            RunDownloadSync();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"Time elapsed: {elapsedMs}");
        }

        static async Task ExecuteAsync()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            await RunDownloadAsync();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"Time elapsed: {elapsedMs}");
        }

        static void RunDownloadSync()
        {
            List<string> websites = PrepData();

            foreach (string site in websites)
            {
                WebsiteDataModel results = DownloadWebsite(site);
                ReportWebsiteInfo(results);
            }
        }

        static async Task RunDownloadAsync()
        {
            List<string> websites = PrepData();

            foreach (string site in websites)
            {
                WebsiteDataModel results = await Task.Run(() => DownloadWebsite(site));
                ReportWebsiteInfo(results);
            }
        }

        private static WebsiteDataModel DownloadWebsite(string websiteURL)
        {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient client = new WebClient();

            output.WebsiteUrl = websiteURL;
            output.WebsiteData = client.DownloadString(websiteURL);

            return output;
        }

        private static void ReportWebsiteInfo(WebsiteDataModel data)
        {
            Console.WriteLine($"{data.WebsiteUrl } downloaded: { data.WebsiteData.Length } chars long.");
        }

        private static List<string> PrepData()
        {
            List<string> output = new List<string>();

            output.Add("https://www.youtube.com");
            output.Add("https://www.google.com");
            output.Add("https://www.microsoft.com");
            output.Add("https://www.yahoo.com");
            output.Add("https://www.stackoverflow.com");
            output.Add("https://www.cnn.com");
            output.Add("https://www.codeproject.com");

            return output;
        }
    }
}

