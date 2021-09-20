using System;
using System.Diagnostics;
using System.Globalization;
using System.Security.Claims;
using System.Text;

namespace CsharpStringManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = StringConversion("StrinG To tEsT yOu;");
            Console.WriteLine(text);

            Console.WriteLine("# Performance counting:");
            ConcatStringPerformance();
            Console.WriteLine();
            StringBuilderPerformance();
        }

        private static string StringConversion(string text)
        {
            var result = string.Empty;

            var textInfo = CultureInfo.CurrentCulture.TextInfo;

            result = textInfo.ToTitleCase(text);
            
            return result;
        }

        private static void ConcatStringPerformance()
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            var test = string.Empty;

            for (var i = 0; i < 100000; i++)
            {
                test += i;
            }

            stopwatch.Stop();
            Console.WriteLine($"- Regular concatenation string stopwatch: { stopwatch.ElapsedMilliseconds }ms");
        }

        private static void StringBuilderPerformance()
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            StringBuilder test = new();

            for (var i = 0; i < 100000; i++)
            {
                test.Append(i);
            }

            stopwatch.Stop();
            Console.WriteLine($"- Regular string builder stopwatch: { stopwatch.ElapsedMilliseconds }ms");
        }
    }
}
