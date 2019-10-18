using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmlSerialize
{
   [Serializable]
   public class Ornek{
        
        public int x {get;set; }
        public int y {get;set ;}

        public List<string> z{get;set;}

        
        public void xmlKaydet(){
            var xml=new XmlSerializer(typeof(Ornek));
            StreamWriter sw=new StreamWriter(@"OrnekXML.xml");
            xml.Serialize(sw,this);
        } 
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Ornek orn=new Ornek();
            orn.x=10;
            orn.y=20;
            orn.z=new List<string>{"Deneme1","Deneme2","Deneme3"};
            try{
                orn.xmlKaydet();
            }catch(Exception e){
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
