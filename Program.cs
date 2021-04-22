using System;
using System.IO;
using System.Linq;
using System.Globalization;

namespace dotnetDatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"StockData.csv");

            foreach (var line in lines.Skip(1))
            {
                var segments = line.Split(',');

                var tradeDate = DateTime.Parse(segments[1], CultureInfo.GetCultureInfo("en-GB"));

                Console.WriteLine(tradeDate.ToLongDateString());
            }
        }
    }
}
