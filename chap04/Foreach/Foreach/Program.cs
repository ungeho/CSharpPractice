using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new[] { "松" , "竹" , "梅"};
            for (var i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
            //中身が無くなるまで繰り返してくれる
            foreach(var val in data)
            {
                Console.WriteLine(val);
            }
        }
    }
}
