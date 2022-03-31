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
            //Word word = new Word("Word", 100);
            //Pdf pdf = new Pdf("PdfDocument", 120);
            //new PrintFile(excel);
            //new PrintFile(word);
            //new PrintFile(pdf);
            //Console.WriteLine("----------------------------");
            #endregion
            #region Generic
            Excel excel = new Excel("Text.txt", 100, 10);
            Word word = new Word("Word", 100);
            Pdf pdf = new Pdf("PdfDocument", 120);
            PrintFileGeneric<Word> printfilegeneric = new PrintFileGeneric<Word>();
            PrintFileGeneric<Pdf> printfilegeneric2 = new PrintFileGeneric<Pdf>();
            PrintFileGeneric<Excel> printfilegeneric3 = new PrintFileGeneric<Excel>();
            printfilegeneric.Print(word);
            printfilegeneric2.Print(pdf);
            printfilegeneric3.Print(excel);
           
            #endregion

        }
    }
}
