using System;
using System.IO;
using System.Net;
using DocumentFormat.OpenXml.Office.CustomUI;
using Microsoft.EntityFrameworkCore;

namespace RandomQuotesGenerator.Retriever
{
    class Program
    {
        private static object dbo;

        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            String downloadedString = client.DownloadString("https://type.fit/api/quotes");
            Console.WriteLine(downloadedString);
        }


    }
}
