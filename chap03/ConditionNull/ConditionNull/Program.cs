using System;

namespace ConditionNull
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "山田";
            string def = "浅田";
            //strがnullでなければstr nullならばdefが出力される。
            Console.WriteLine(str ?? def);
            str = null;
            Console.WriteLine(str ?? def);
            //条件演算子だと
            Console.WriteLine(str == null ? def : str);

        }
    }
}
