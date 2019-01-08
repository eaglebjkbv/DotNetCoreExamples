using System;
using NameSpaceClass.Hayvan;

namespace NameSpaceClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Kopek dobi=new Kopek();
            System.Console.WriteLine($"Köpekler {dobi.sesver()} derler...");
        }
    }
}
