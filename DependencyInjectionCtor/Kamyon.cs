namespace DependencyInjectionCtor
{
    
    public class Kamyon :IAraba
    {
        public Kamyon(int _model,string _renk)
        {
            Model = _model;
            Renk = _renk;

        }
        public int Model { get; set; }
        public string Renk { get; set; }
    }
}