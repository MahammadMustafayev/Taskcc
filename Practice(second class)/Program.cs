using System;
using Practice_second_class_.Models;

namespace Practice_second_class_
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintFile printFile = new PrintFile();           
            //Excel excel = new Excel(12,6);
            printFile.Print();
        }
    }
}
