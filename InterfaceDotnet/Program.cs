using System;

namespace InterfaceDotnet
{

    interface IHayvan{
        string sesver();
    }

    class Kopek:IHayvan{
        public string sesver()
        {
            return "hav Hav";
        }
    }
    class Kedi:IHayvan{
        public string sesver(){
            return "Miyav";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kopek dobi=new Kopek();
            
            System.Console.WriteLine($"Kopekler {dobi.sesver()} derler");   

            Kedi mirnav=new Kedi();
            System.Console.WriteLine($"Kediler {mirnav.sesver()} derler");
        }
    }
}
