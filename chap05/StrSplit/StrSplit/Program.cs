using System;
using System.Globalization;


namespace StrSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            //文字列の分割
            var str1 = "うめ,もも,さくら";
            var result1 = str1.Split(',');
            Console.WriteLine(string.Join("&", result1)); 
            //うめ&もも&さくら

            var str2 = "うめ,もも|さくら";
            var result2 = str2.Split(',','|'); //複数の区切り文字を指定
            Console.WriteLine(string.Join("&", result2));
            //うめ&もも&さくら

            var str3 = "うめ  もも\tさくら\nあんず　くるみ,もみじ";
            var result3 = str3.Split(); //指定なし (半角/半角)の空白,タブ文字,改行等が区切り文字
            Console.WriteLine(string.Join("&", result3));
            //うめ&&もも&さくら&あんず&くるみ,もみじ


            var str4 = "うめ,もも,さくら,あんず";
            var result4 = str4.Split(new[] { ','},2); //0~2文字目まで
            Console.WriteLine(string.Join("&", result4));
            //うめ&もも,さくら,あんず



            //フォーマット
            Console.WriteLine("名前は{0}です。","サクラ");
            Console.WriteLine("名前は{0,5}です。", "サクラ"); //右寄せ 5文字分スペース確保
            Console.WriteLine("名前は{0,-5}です。", "サクラ");//左寄せ 5文字分スペース確保
            Console.WriteLine(string.Format("10進数8桁{0:d8}",1234));
            Console.WriteLine(string.Format("指数表記{0:e2}", 1234));
            Console.WriteLine(string.Format("日付:{0:D}",DateTime.Now));
            var price = 1000;
            Console.WriteLine($"価格：{price:c}");



        }
    }
}
