using System;
using System.Collections.Generic;


namespace GenericListUygulamasi
{
    class Kitap
    {
        public int id { get; set; }
        public String adi { get; set; }
        public int adet { get; set; }
        public DateTime cikisTarihi { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Kitap> kitaplar=new List<Kitap>(){
            new Kitap(){id=1,adi="Merhaba Dünya",adet=20,cikisTarihi=DateTime.Now},
            new Kitap(){id=2,adi="Merhaba Dotnet",adet=30,cikisTarihi=DateTime.Now},
            new Kitap(){id=3,adi="Merhaba Python",adet=40,cikisTarihi=DateTime.Now},
            new Kitap(){id=4,adi="Merhaba Core",adet=50,cikisTarihi=DateTime.Now},

            };
            
            Kitap kit1=new Kitap();
            kit1.id=5;
            kit1.adi="Merhaba Asp.Net";
            kit1.adet=10;
            DateTime dt=new DateTime(2018,12,11);
            kit1.cikisTarihi=dt;
            kitaplar.Add(kit1);
            
        foreach (var kitap in kitaplar)
        {
            Console.WriteLine("Kitap id={0} Kitap Adi={1}",kitap.id,kitap.adi);
            
        }


        }
    }
}
