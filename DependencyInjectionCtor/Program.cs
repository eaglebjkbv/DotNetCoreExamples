using System;
using DefaultNamespace;

namespace DependencyInjectionCtor
{
    class Program
    {
        static void Main(string[] args)
        {
            EsasAraba esasAraba1 = new EsasAraba(new Otomobil(1998,"Kırmızı"));

            esasAraba1.tumOzellikler();
            EsasAraba esasAraba2=new EsasAraba(new Kamyon(2010,"Yeşil"));
            
            esasAraba2.tumOzellikler();
        }
    }
}
