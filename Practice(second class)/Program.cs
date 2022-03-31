using System;
using Practice_second_class_.Models;

namespace Practice_second_class_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Non-Generic
            Excel excel = new Excel("Text.txt",100,10);
            Word word = new Word("Word", 100);
            Pdf pdf = new Pdf("PdfDocument", 120);
            new PrintFile(excel);
            new PrintFile(word);
            new PrintFile(pdf);
            Console.WriteLine("----------------------------");
            #endregion
            #region Generic
            PrintFileGeneric<IPrintablefile> printfilegeneric = new PrintFileGeneric<IPrintablefile>();
            printfilegeneric.Print(word);
            printfilegeneric.Print(pdf);
            printfilegeneric.Print(excel);
            #endregion

        }
    }
}
