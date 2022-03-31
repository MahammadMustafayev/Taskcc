using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_second_class_.Models
{

    class Pdf : IPrintablefile
    {
        public int PageCount { get; set; }
        public string FileName { get; set; }

        public Pdf(string fileName, int pageCount)
        {
            FileName = fileName;
            PageCount = pageCount;
        }

        public void Print()
        {
            Console.WriteLine($"FileName:{FileName}  PageCount:{PageCount}");
        }


    }
}
