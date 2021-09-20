using System;
using System.Globalization;
using System.Security.Claims;

namespace CsharpStringManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = StringConversion("StrinG To tEsT yOu;");
            Console.WriteLine(text);
        }

        private static string StringConversion(string text)
        {
            var result = string.Empty;

            var textInfo = CultureInfo.CurrentCulture.TextInfo;

            result = textInfo.ToTitleCase(text);
            
            return result;
        }
    }
}
