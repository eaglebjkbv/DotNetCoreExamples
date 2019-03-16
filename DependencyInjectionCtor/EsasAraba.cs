using System;
using DependencyInjectionCtor;

namespace DefaultNamespace
{
    public class EsasAraba
    {
        private IAraba _araba;

        public EsasAraba(IAraba araba) //Gönderilen Nesne IArabadan implement edilen her class olabilir.
        {
            _araba = araba;
        }

        public void tumOzellikler()
        {
            Console.WriteLine($"Aracın modeli : {_araba.Model}");
            Console.WriteLine($"Aracın Rengi :{_araba.Renk}");
            
        }


    }
}