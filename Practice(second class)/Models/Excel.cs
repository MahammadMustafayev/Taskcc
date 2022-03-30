using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_second_class_.Models
{
    #region Non-Generic
    //class Excel :IPrintablefile 
    //{
    //    public int ColumnCount { get; set; }
    //    public int RowCount { get; set; }
    //    public string FileName { get; set; }

    //    public Excel(string fileName,int columnCount,int rowCount)
    //    {
    //        FileName = fileName;
    //        ColumnCount = columnCount;
    //        RowCount = rowCount;
    //    }

    //    public void Print()
    //    {
    //        Console.WriteLine($"FileName:{FileName}  ColumnCount:{ColumnCount}  RowCount:{RowCount}");
    //    }
    #endregion
    #region Generic
    class Excel<T,U> : IPrintablefile
    {
        public T ColumnCount { get; set; }
        public T RowCount { get; set; }
        public U FileName { get; set; }
        string IPrintablefile.FileName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Excel(U fileName, T columnCount, T rowCount)
        {
            FileName = fileName;
            ColumnCount = columnCount;
            RowCount = rowCount;
        }

        public void Print()
        {
            Console.WriteLine($"FileName:{FileName}  ColumnCount:{ColumnCount}  RowCount:{RowCount}");
        }
        #endregion
    }
}
