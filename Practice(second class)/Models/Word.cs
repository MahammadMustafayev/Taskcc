using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_second_class_.Models
{
    #region Non-Generic
    //class Word :IPrintablefile
    //{
    //    public int WordCount { get; set; }
    //    public string FileName { get; set; }

    //    public Word(string fileName,int wordCount)
    //    {
    //        FileName = fileName;
    //        WordCount = wordCount;
    //    }

    //    public void Print()
    //    {
    //        Console.WriteLine($"FileName:{FileName} WordCount:{WordCount}");
    //    }
    //}
        #endregion
        #region Generic
        class Word<T,U> : IPrintablefile
        {
            public T WordCount { get; set; }
            public U FileName { get; set; }
        string IPrintablefile.FileName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Word(U fileName, T wordCount)
            {
                FileName = fileName;
                WordCount = wordCount;
            }

            public void Print()
            {
                Console.WriteLine($"FileName:{FileName} WordCount:{WordCount}");
            }
        }
        #endregion
    }

