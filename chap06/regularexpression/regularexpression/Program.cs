using System;
using System.Text.RegularExpressions;

namespace regularexpression
{
    class Program
    {
        static void Main(string[] args)
        {
            var tel = new[] {"080-0000-0000", "084-0000-0000" , "184-0000" };
            var rgx = new Regex(@"\d{2,4}-\d{2,4}-\d{2,4}");
            foreach(var t in tel)
            {
                Console.WriteLine(rgx.IsMatch(t) ? t : "アンマッチ");

            }
        }
    }
}
