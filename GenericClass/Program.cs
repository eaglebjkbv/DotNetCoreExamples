using System;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyGenericClass<int> myGeneric=new MyGenericClass<int>();
            myGeneric.deneme(100);
        }
    }
    public class MyGenericClass<T>
    {
        public void deneme(T deger){
            System.Console.WriteLine(deger);
        }
    }
}
