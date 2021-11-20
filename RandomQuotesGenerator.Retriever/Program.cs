using System;
using System.IO;
using System.Net;
using DocumentFormat.OpenXml.Office.CustomUI;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace RandomQuotesGenerator.Retriever
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            String downloadedString = client.DownloadString("https://type.fit/api/quotes");

            var quoteList = JsonConvert.DeserializeObject<QuotesEntity[]>(downloadedString);

            using (var context = new QuotesContext())
            {

                for (int i = 0; i < quoteList.Length; i++)
                {
                    context.Quotes.Add(quoteList[i]);
                }

                context.SaveChanges();
            }


     






        }

    }
}
