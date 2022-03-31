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
        
        public void Print(T file)
        {
            file.Print();
            
        }
    }
    #endregion
}
