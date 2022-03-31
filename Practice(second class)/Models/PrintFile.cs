using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_second_class_.Models
{
    #region Non-Generic
    class PrintFile
    {
        public PrintFile(IPrintablefile file)
        {
            file.Print();
        }
    }
    #endregion
    #region Generic
    class PrintFileGeneric<T>
        where T:IPrintablefile
    {
        //public PrintFileGeneric(T file)
        //{

        //}
        public void Print(T file)
        {
            if (file is Word word)
            {
                word.Print();
            }
            if (file is Pdf pdf)
            {
                pdf.Print();
            }
            if (file is Excel excel)
            {
                excel.Print();
            }
            
        }
    }
    #endregion
}
