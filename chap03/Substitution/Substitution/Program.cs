using System;
using System.Text;
using System.Linq;


namespace Substitution
{
    class Program
    {
        static void Main(string[] args)
        {
            //参照型の代入はポインタと同じように参照するアドレスを渡す事になる。
            //builder2もbuilder1と同じアドレスを参照してるのでbuilder1と同じ出力結果になる
            var builder1 = new StringBuilder("あいう");
            var builder2 = builder1;
            builder1.Append("えお");
            Console.WriteLine(builder1.ToString());
            Console.WriteLine(builder2.ToString());

            //同一性と同値性
            var builder3 = new StringBuilder("あいう");
            var builder4 = new StringBuilder("あいう");
            //値は同じだが異なるインスタンスなのでfalse
            //ただし,Stringクラスは例外で == は両辺がStringのときのみ？） Equalsメソッドが呼ばれるので同値ならTrueになる。
            Console.WriteLine(builder3 == builder4);
            //同値なのでtrue
            //ただし, int == String や String == int はエラーになるが String.Equals(int)は任意の型を受け取れてしまう為、エラーを返さずfalseを返してしまう。 Stringは == を使った方が良い。
            Console.WriteLine(builder3.Equals(builder4));

            //配列の比較
            var data1 = new[] { "い", "ろ", "は" };
            var data2 = new[] { "い", "ろ", "は" };
            //参照を比較するのでどちらもfalse
            Console.WriteLine(data1 == data2);
            Console.WriteLine(data1.Equals(data2));
            //EnumerableクラスのSquenceEqalメソッドで比較が出来る。
            Console.WriteLine(data1.SequenceEqual(data2));



        }
    }
}
