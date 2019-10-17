using System;

namespace ClassExample
{
    class Ogrenci{
        public int id;
        public string adi;
        public string soyadi;
        public DateTime dogumTarihi;

        public string yaz(){
            
            return string.Format("Numarası: {0} Adi : {1} Soyadı : {2} Doğum Tarihi: {3} ",id,adi,soyadi,dogumTarihi);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci=new Ogrenci();
            ogrenci.id=1;
            ogrenci.adi="Mehmet";
            ogrenci.soyadi="Öztürk";
            ogrenci.dogumTarihi=new DateTime(2019,1,1);

            Console.WriteLine(ogrenci.yaz());
            Console.WriteLine(ogrenci.yaz());
            
        }
    }
}
