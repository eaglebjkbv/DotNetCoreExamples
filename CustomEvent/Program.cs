using System;

namespace CustomEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            OduncKitap kitap=new OduncKitap();
            kitap.OduncKitapSuresiDoldu+=SureDoldu;
            kitap.OduncKitapVer();
        }
        public static void SureDoldu(object o, KitapEventArgs e){
            System.Console.WriteLine($"{e.KitapAdi} :Kitabının Ödünç süresi doldu");

        }
    }
}
