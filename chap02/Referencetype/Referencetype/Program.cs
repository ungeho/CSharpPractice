using System;

namespace Referencetype
{
    class Program
    {
        static void Main(string[] args)
        {
            //trimは先頭と末尾の空白文字の除去
            String str = "   aaaaa  ";
            Console.WriteLine(str.Trim());
            Console.WriteLine(str);


            //特に,参照型は明示的に宣言しない限り初期値はnullになる。
            // NullReferenceException を避ける為に空の配列を返すなど、出来るだけnull値を避ける。
            str = null;
            //String unspace = str.Trim(); NullReferenceExceptionエラー

            //null条件演算子 ?. オブジェクトが非nullの時のみメンバーにアクセス。(nullの場合はnullを返す。)
            String unspace = str?.Trim(); //エラーにならないがunspaceにnullが入る
            //C#6以前はifを使う
            if (str != null) unspace = str.Trim();

            //null許容型（Nullable） 値型でnullを表現したい時に使う(値として無効な状態か有効な状態かの区別など)
            int? num1 = 100;
            int? num2 = null;
            Nullable<int> num3;
            //int num2 = null; エラー 通常の値型はnullを許容していない
            //String? str; 　　エラー 参照型は既にnullを使用出来る

            int? a = 3;
            int  b = 4;
            Console.WriteLine(a + b);

            //配列（参照型）の宣言
            int[]    data  = new int[5];            //サイズのみの指定
            int[]    data2 = { 1, 2, 3, 4, 5 };     //初期化値を指定
            //末尾の要素をカンマで終えても問題ないらしい "たちつてと",
            String[] data3 = {
                "あいうえお",
                "かきくけこ",
                "たちつてと", 
            };
            //宣言と初期化を別にした場合はnew[]を省略できない
            int[] data4;
            data4 = new[] { 1, 2, 3, 4, 5 };
            //varによる配列の宣言
            //型推論の為、var[]とすることは出来ない。その為に new[] は省略出来ない。
            var data5 = new[] { 1, 2, 3, 4, 5 };
            for (var i = 0; i < data5.Length; i++) Console.Write("  {0}", data5[i]);
            Console.WriteLine();

            //多次元配列
            int[,]  data6 = new int[3,3];
            int[,,] data7 = new int[3,3,3];
            int[,]  data8 = new[,]
            {
                {   1,  2,  3   },
                {   4,  5,  6   },
            };

            //ジャグ配列　入れ子にすることで要素数が不揃いな配列を定義する
            //[,]ではなく[][]
            int[][] data9 = new int[3][];
            data9[0] = new int[2];
            data9[1] = new int[4];
            data9[2] = new[] {  3,  4,  5};

            //多次元配列の要素数
            var multi = new[,]
            {
                {10,20,30 },
                {40,50,60 }
            };
            Console.WriteLine(multi.Length); //二次元配列の全ての要素数を返す 6
            var jagged = new int[3][];
            jagged[0] = new[] { 1, 2, 3, 4, 5 };
            jagged[1] = new[] { 1, 5 };
            jagged[2] = new[] { 1, 4, 5 };
            Console.WriteLine(jagged.Length);    //要素に配列を持つ一次元配列である為  3
            Console.WriteLine(jagged[0].Length); //0番目の配列の要素数の5を返す
            var s = 0;
            for (var i = 0; i < jagged.Length; i++) s += jagged[i].Length;
            Console.WriteLine(s); //ジャグ配列の全要素数 10

            //次元数 Rank
            Console.WriteLine(multi.Rank);   //2次元配列なので2
            Console.WriteLine(jagged.Rank);  //１次元配列なので1



        }
    }
}
