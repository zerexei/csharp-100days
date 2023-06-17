using System;
using System.Text;

using Foo;
using WorkingWithCollection;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Scrape scrape = new Scrape();
            scrape.ScrapeWebPage();

            Collection collection = new Collection();
            collection.log();

            Console.WriteLine(@"Thank you C\\:user");
        }
    }
}