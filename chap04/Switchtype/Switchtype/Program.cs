using System;

namespace Switchtype
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = -123; //object型は任意の方を代入出来る

            switch(obj)
            {
                //C#7以降　caseに値だけでなく型を指定出来る。
                //値ではなく型で判定

                //intなら絶対値
                case int i:
                    Console.WriteLine(Math.Abs(i));
                    break;
                //stringなら先頭文字
                case string str:
                    Console.WriteLine(str[0]);
                    break;
                default:
                    Console.WriteLine("意図しない型です。");
                    break;
            }
        }
    }
}
