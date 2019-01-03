using System;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            var ogrenci=new {num=1,ad="Hasan",soyad="Can" }; // Burada oluşacak verinin class tasımalaması yapılmamış "var ogrenci" bu anonymous type dır. 
            System.Console.WriteLine($"Öğrenci No: {ogrenci.num} \nÖğrenci Adi: {ogrenci.ad}");
            System.Console.WriteLine($"Öğrenci No: {ogrenci.num} \nÖğrenci Adi: {ogrenci.ad}");

            // Örnek bir Anonymous dizi oluşturma

            var hayvanlar=new[] {
                                new {adi="Köpek",kilosu=10},
                                new {adi="Kedi", kilosu=5}

                            };
        if(hayvanlar!=null){
                foreach (var item in hayvanlar)
                {
                    System.Console.WriteLine($"Hayvan Adı : {item.adi} , Hayvanın Kilosu : {item.kilosu}");
                }
        }
        }
    }
}
