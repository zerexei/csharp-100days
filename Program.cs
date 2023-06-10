using System;
using System.Text;

using Foo;
using Bar.Foo;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Scrape scrape = new Scrape();
            scrape.ScrapeWebPage();

            Foo.Fooz();
            Console.WriteLine(@"Thank you C\\:user");
        }
    }
}