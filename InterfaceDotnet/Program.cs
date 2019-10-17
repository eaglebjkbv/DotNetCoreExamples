using System;
<<<<<<< HEAD
using InterfaceDotnet.Hayvan;

namespace InterfaceDotnet
{
=======

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
>>>>>>> dbe3611e010c5a4fe9491cbbc515426da3328099
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Kedi kedi=new Kedi();
            System.Console.WriteLine($"Kedi Sesi {kedi.sesver()}");
=======
            Kopek dobi=new Kopek();
            
            System.Console.WriteLine($"Kopekler {dobi.sesver()} derler");   

            Kedi mirnav=new Kedi();
            System.Console.WriteLine($"Kediler {mirnav.sesver()} derler");
>>>>>>> dbe3611e010c5a4fe9491cbbc515426da3328099
        }
    }
}
