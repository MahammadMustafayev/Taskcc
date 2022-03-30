using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_second_class_.Models
{
    public interface IPrintablefile
    {
        public string FileName { get; set; }
        public void Print();
    }
}
