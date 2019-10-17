using System;
using PersonDal;

namespace AnaProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person=new Person();
            person.ad="Bülent";
            Console.WriteLine($" Merhaba {person.ad}");
        }
    }
}
