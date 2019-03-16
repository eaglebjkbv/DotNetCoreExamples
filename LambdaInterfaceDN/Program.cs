using System;

namespace LambdaInterfaceDN
{
    class Program
    {
        static void Main(string[] args)
        {
            Kopek dobi=new Kopek();
            System.Console.WriteLine($"Köpekler {dobi.sesver()} der");
            Kedi tekir=new Kedi();
            System.Console.WriteLine($"Kediler {tekir.sesver()} der");

        }
    }
}
