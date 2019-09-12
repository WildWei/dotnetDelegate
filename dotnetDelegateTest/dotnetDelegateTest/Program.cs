using System;

namespace dotnetDelegateTest
{
    /// <summary>
    /// 印出一些東西 的 委派事件 
    /// </summary>
    /// <param name="number">數字</param>
    public delegate void WriteSometing(int number);

    class Program
    {
        static void Main(string[] args)
        {
            WriteSometing delegateTestA = new WriteSometing(WriterFunc.PrintNumber);

            delegateTestA.Invoke(8);

            Console.WriteLine("============================================================");

            WriteSometing delegateTestB = new WriteSometing(WriterFunc.SquareFunction);

            delegateTestB += WriterFunc.RadicalFunction;

            delegateTestB += WriterFunc.PrintNumber;

            delegateTestB += WriterFunc.SquareFunction;

            delegateTestB.Invoke(25);
        }
        
    }
}
