using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_second_class_.Models
{

    class Word : IPrintablefile
    {
        public int WordCount { get; set; }
        public string FileName { get; set; }

        public Word(string fileName, int wordCount)
        {
            FileName = fileName;
            WordCount = wordCount;
        }

        public void Print()
        {
            Console.WriteLine($"FileName:{FileName} WordCount:{WordCount}");
        }
    }


}

