using DependencyInjectionCtor;

namespace DefaultNamespace
{
    public class Otomobil: IAraba
    {
        public Otomobil(int _model,string _renk)
        {
            Model = _model;
            Renk = _renk;

        }
        public int Model { get; set; }
        public string Renk { get; set; }
    }
}