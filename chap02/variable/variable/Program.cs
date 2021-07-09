using System;

namespace variable
{
    class Program
    {
        static void Main(string[] args)
        {
            //varは型推論　右辺の初期化子の型が明らかな時とforやforeachで使用。
            var bl   = true;              //bool型　表示するとTrue/Falseだがコードではtrue/falseであることに注意。
            Console.WriteLine(bl);
            bl       = false;
            Console.WriteLine(bl);
            var chr  = 'a';              //char型
            Console.WriteLine(chr);
            var str  = "aaaaaaaaaa";     //string型
            Console.WriteLine(str);
            var num1 = 1;                //int型
            Console.WriteLine(num1);
            var num2 = 1.0;              //double型
            num2 = 1.5;
            Console.WriteLine(num2);

            Console.WriteLine();


            //数値セパレーター 桁数の大きな値を_で区切って見やすくできる。
            num1 = 12_34_56;
            num1 = 12___34_56;
            Console.WriteLine(num1);

            Console.WriteLine();



            //文字列 <-> 数値　の変換
            int    i = 15;
            double d = 1.25;
            Console.WriteLine(i + d);                       // 15 + 1.25 = 16.25
            Console.WriteLine(i.ToString() + d.ToString()); //"15"と"1.25"を連結して"151.25"を出力
            Console.WriteLine(Convert.ToString(i,16));      //16進数に変換した文字列
            i = Convert.ToInt32("125");
            d = Convert.ToDouble("1.5");
            Console.WriteLine(i + d);                       // 125 + 1.5 = 126.5


            Console.WriteLine();




            //逐語的文字列リテラル 文字列リテラルの先頭に @ をつけることで\\や\nなどのエスケープシーケンスの省略が出来る。
            Console.WriteLine("C:\\hoge\\hoge\\huga");
            Console.WriteLine(@"C:\hoge\hoge\huga");
            
            Console.WriteLine("hoge\nhoge\nhoge");
            //改行もタブ文字もそのまま適用される。
            Console.WriteLine(@"hoge
hoge
hoge");
            Console.WriteLine(@"hoge
                                hoge
                                hoge");

            Console.WriteLine();



            //文字列への変数展開 文字列リテラルの先頭に $ をつけることで{}の中に変数を埋め込む事が出来る
            string name = "浅田";
            Console.WriteLine("こんにちは{0}さん", name);
            Console.WriteLine($"こんにちは{name}さん");
            Console.WriteLine($"5*4の答えは{5*4}です。");
            Console.WriteLine($"exp(1)は{Math.Exp(1)}です。");
            //逐語的文字列リテラルと組み合わせることも可能。(ただし@$は不可)
            string hoge = "hogehoge";
            Console.WriteLine($@"C:\example\{hoge}");

            


        }
    }
}
