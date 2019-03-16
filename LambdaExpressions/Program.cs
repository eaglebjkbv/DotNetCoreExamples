using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class personel
    {
        public int id { get; set; }
        public string Ad { get; set; }
        public string soyad { get; set; }
        public int maas { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Listeye veri ekleme  methodları ...,
            // Toplu olarak ekleme
            List<personel> calisanlar = new List<personel>{
                                                            new personel{id=1,Ad="Bülent",soyad="Kartal",maas=1000},
                                                            new personel{id=2,Ad="Ahmet",soyad="Duman",maas=2000},
                                                            new personel{id=3,Ad="Mehmet",soyad="Yaman",maas=3000},
                                                            new personel{id=4,Ad="Elif",soyad="Kurt",maas=4000},

                                                        };

            // Tek Tek Ekleme
            calisanlar.Add(new personel {id=10,Ad="Cevat",soyad="Kelle",maas=10000});
            
            
            //referans oluşturarak ekleme
            personel per=new personel();
            per.id=12;
            per.Ad="Ömer";
            per.soyad="Kaan";
            per.maas=1300;

            calisanlar.Add(per);

            

            var maasikibinaltinda = calisanlar.Where(i => i.maas <= 2000); //Örneğin burada maaşı 2000 in altında olan kişiler isteniyor.
             if (maasikibinaltinda != null) // Dönen değer null değil ise listeleme yapılmalıdır.
            {
                Console.WriteLine("Maaşı 2000 ve Altında olan Kişiler");
                Console.WriteLine("----------------------------------");
                foreach (var item in maasikibinaltinda)
                {
                    System.Console.WriteLine(item.Ad);
                }
            }
            
            
            var adiailebaslayanlar = calisanlar.Where(i => i.Ad.StartsWith("A")); //Adı A ile başlayan tüm kayıtlar adiailebslayanlar anonm değikenine atar.
            if (adiailebaslayanlar != null)
            {
                Console.WriteLine("\nAdı A ile Başlayanlar");
                Console.WriteLine("----------------------------------");
                foreach (var item in adiailebaslayanlar)
                {
                    System.Console.WriteLine("ad: {0} Soyadı : {1} ", item.Ad, item.soyad);
                }
            }
            List<personel> kisiler=calisanlar.Where(i=> i.id>2).ToList(); // kisiler listesine yeni liste atama
            if (kisiler!= null)
            {
                Console.WriteLine("\nId si 2 den büyük olanlar....");
                Console.WriteLine("----------------------------------");
                foreach (var item in kisiler)
                {
                    System.Console.WriteLine("ad: {0} Soyadı : {1} ", item.Ad, item.soyad);
                }
            }

            var secilenler=calisanlar.Where(i=>i.id>1).Select(i=> new {i.Ad,i.soyad}).ToList(); // Seçilen veriler Anonymous bir tipe atılıyor. 
            if (secilenler!= null)
            {
                Console.WriteLine("\nId si 1 den büyük olanlar....");
                Console.WriteLine("----------------------------------");
                foreach (var item in secilenler)
                {
                    System.Console.WriteLine("ad: {0} Soyadı : {1} ", item.Ad, item.soyad);
                    // System.Console.WriteLine("Maas : ",item.maas); Burada Hata verir..... Çünkü secilenler dizisinde maas bilgisi yok.

                }
            }
            // Linq cümlesi ile seçim yapma
            List<personel> secilenPersonel=(from i in calisanlar
                                            where i.id<3
                                            select i).ToList();
            if (secilenPersonel!= null)
            {
                Console.WriteLine("\nID si 3 ün altında olanlar...");
                Console.WriteLine("----------------------------------");
                foreach (var item in secilenPersonel)
                {
                    System.Console.WriteLine("ad: {0} Soyadı : {1} ", item.Ad, item.soyad);
                    

                }
            }
           
            
            
        }
    }
}
