using System;
using Practice_second_class_.Models;

namespace Practice_second_class_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Non-Generic
            //Excel excel = new Excel("Text.txt",100,10);
            //excel.Print();
            #endregion
            #region Generic
            Excel<int,string> excel = new Excel<int,string>("Text.txt", 100, 10);
            excel.Print();
            Word<int, string> word = new Word<int, string>("Word",100);
            word.Print();
            #endregion
        }
    }
}
