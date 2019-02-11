using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adim="Mehmet";
            string sonuc=Adim.Degistir(); // string class ı methodlarına Değiştir eklendi.
            Console.WriteLine(sonuc);
        }
    }
}
