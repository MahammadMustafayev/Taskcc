using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_second_class_.Models
{
    class PrintFile
    {
     
        public PrintFile(IPrintablefile file)
        {
            file.Print();
        }
      
    }
}
