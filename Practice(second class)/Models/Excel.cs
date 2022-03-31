using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_second_class_.Models
{

    class Excel : IPrintablefile
    {
        public int ColumnCount { get; set; }
        public int RowCount { get; set; }
        public string FileName { get; set; }

        public Excel(string fileName, int columnCount, int rowCount)
        {
            FileName = fileName;
            ColumnCount = columnCount;
            RowCount = rowCount;
        }

        public void Print()
        {
            Console.WriteLine($"FileName:{FileName}  ColumnCount:{ColumnCount}  RowCount:{RowCount}");
        }


    }
}
