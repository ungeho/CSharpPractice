using System;

namespace OtherOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //sizeof 値型のサイズをバイト単位で取得
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(decimal));

            //nameof 識別子を文字列リテラルとして取得
            int data = 4;
            Console.WriteLine(nameof(OtherOperator));
            Console.WriteLine(nameof(data));
            String str = null;
            if (str == null) throw new ArgumentNullException(nameof(str));
        }
    }
}
