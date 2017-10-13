using System;

namespace PI_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new Encryption(ReaderRegedit.GetValue());
            Console.WriteLine($"Serial key: {encoder.ChangeKey()}");
            Console.ReadLine();
        }
    }
}
