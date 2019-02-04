using System;
namespace CustomEvent
{ 
    public class KitapEventArgs : EventArgs{
        public string  KitapAdi { get; set; }
    }
    

    public class OduncKitap
    {
        public delegate void OduncKitapEventHandler(object o ,KitapEventArgs e);
        public event OduncKitapEventHandler OduncKitapSuresiDoldu;
        public void OduncKitapVer(){
            System.Console.WriteLine("Kitap Ödünç Verildi .. ");
            SuresiDoldu();
        }

        protected virtual void SuresiDoldu(){
            if(OduncKitapSuresiDoldu!=null){
                OduncKitapSuresiDoldu(this,new KitapEventArgs()
                { KitapAdi="Beyaz Zambaklar Ülkesi"});

            }
        }
    }
}