using System;


namespace PreIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
#if DEBUG
            Console.WriteLine("Debug version");
#endif
            //折りたためるようになる
            #region 定数/変数の定義
            var aaaa = "ああああ";
            int b = 12345;
            #endregion
        }
    }
}
