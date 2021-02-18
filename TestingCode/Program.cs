using System;
using System.Globalization;
using System.Threading;

namespace TestingCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var cul = CultureInfo.CreateSpecificCulture("de-DE");
            var culE = CultureInfo.CreateSpecificCulture("en-US");

            Thread.CurrentThread.CurrentCulture = cul;
            //var c = Decimal.Parse("8,9", CultureInfo.CurrentCulture);

            //Thread.CurrentThread.CurrentCulture = culE;
            //var c1 = Decimal.Parse("8,9", CultureInfo.CurrentCulture);

            //var d = Decimal.Parse("8,9", cul);
            //var e = Decimal.Parse("8,9", culE);
            var source = 67.4;
            string result = source.ToString("n", CultureInfo.GetCultureInfo("de")); 
            var bb = decimal.Parse("5,4", NumberStyles.AllowDecimalPoint, cul);
        }
    }
}
