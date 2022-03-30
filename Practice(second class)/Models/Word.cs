using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_second_class_.Models
{
    class Word:IPrintablefile
    {
        public int WordCount { get; set; }
        public string FileName { get; set; }

        public Word(int wordCount)
        {
            WordCount = wordCount;
        }

        public void Print()
        {
            Console.WriteLine($"WordCount:{WordCount}");
        }
    }
}
