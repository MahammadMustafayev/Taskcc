using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_second_class_.Models
{
    class Pdf:IPrintablefile
    {
        public int PageCount { get; set; }
        public string FileName { get; set; }

        public Pdf(int pageCount)
        {
            PageCount = pageCount;
        }

        public void Print()
        {
            Console.WriteLine($"PageCount:{PageCount}");
        }
    }
}
