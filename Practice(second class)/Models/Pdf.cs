using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_second_class_.Models
{
    #region Non-Generic
    //class Pdf :IPrintablefile
    //{
    //    public int PageCount { get; set; }
    //    public string FileName { get; set; }

    //    public Pdf(string fileName,int pageCount)
    //    {
    //        FileName = fileName;
    //        PageCount = pageCount;
    //    }

    //    public void Print()
    //    {
    //        Console.WriteLine($"FileName:{FileName}  PageCount:{PageCount}");
    //    }
    #endregion
    #region Generic
    class Pdf<T,U> : IPrintablefile
    {
        public T PageCount { get; set; }
        public U FileName { get; set; }
        string IPrintablefile.FileName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Pdf(U fileName, T pageCount)
        {
            FileName = fileName;
            PageCount = pageCount;
        }

        public void Print()
        {
            Console.WriteLine($"FileName:{FileName}  PageCount:{PageCount}");
        }
        #endregion
    }
}
