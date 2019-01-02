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
            List<personel> calisanlar = new List<personel>{
                                                            new personel{id=1,Ad="Bülent",soyad="Kartal",maas=1000},
                                                            new personel{id=1,Ad="Ahmet",soyad="Duman",maas=2000},
                                                            new personel{id=1,Ad="Mehmet",soyad="Yaman",maas=3000},
                                                            new personel{id=1,Ad="Elif",soyad="Kurt",maas=4000},

                                                        };

            var maasikibinaltinda = calisanlar.Where(i => i.maas <= 2000); //Örneğin burada maaşı 2000 in altında olan kişiler isteniyor.
            var adiailebaslayanlar = calisanlar.Where(i => i.Ad.StartsWith("A")); //Adı A ile başlayan tüm kayıtlar adiailebslayanlar anonm değikenine atar.
            if (maasikibinaltinda != null) // Dönen değer null değil ise listeleme yapılmalıdır.
            {
                Console.WriteLine("Maaşı 2000 ve Altında olan Kişiler");
                Console.WriteLine("----------------------------------");
                foreach (var item in maasikibinaltinda)
                {
                    System.Console.WriteLine(item.Ad);
                }
            }
            if (adiailebaslayanlar != null)
            {
                Console.WriteLine("\nAdı A ile Başlayanlar");
                Console.WriteLine("----------------------------------");
                foreach (var item in adiailebaslayanlar)
                {
                    System.Console.WriteLine("ad: {0} Soyadı : {1} ", item.Ad, item.soyad);
                }
            }
            
        }
    }
}
