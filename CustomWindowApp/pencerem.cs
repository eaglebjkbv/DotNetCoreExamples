using System.Windows.Forms;
using System;
using System.Drawing;
namespace CustomWindowApp
{
    public class BenimPencerem:Form
    {
        public BenimPencerem(){
            PencereDuzenle();
        }
        PictureBox[] pb=new PictureBox[100];
        Timer tm;
        int kutuSayisiX=4;
        int kutuSayisiY=4;
        int kutuBoy=60;
        int pLeft=20;
        int pTop=50;

        public void PencereDuzenle()
        {
            
            this.Height=400;
            this.Width=300;
            Button btnDeneme=new Button();
            btnDeneme.Text="Yeniden Başla";
            btnDeneme.Height=40;
            btnDeneme.Width=60;
            btnDeneme.Enabled=false;
            this.Controls.Add(btnDeneme);

        int toplamKutuSayisi=kutuSayisiX*kutuSayisiY;   
        for(int j=0;j<kutuSayisiY;j++)
        {    
            for(int i=0;i<kutuSayisiX;i++)
            {
                pb[i]=new PictureBox();
                pb[i].Size=new Size(kutuBoy,kutuBoy);
                pb[i].Left=pLeft+j*(kutuBoy+2);
                pb[i].Top=pTop+i*(kutuBoy+2);
                pb[i].BackColor=Color.Red;
                this.Controls.Add(pb[i]);
                pb[i].Click+=pb_Clicked;
            }   
        }
        
        tm=new Timer();
        tm.Tick+=tm_Tick;
        tm.Interval=1000;
        

    }

    public void tm_Tick(Object sender, EventArgs e)
    {
        sure++;
        if(sure==3){
            for(int i=0;i<3;i++){
                pbTiklanan[i].BackColor=Color.Red;
            }
        //tm.Stop();
        tikalamaSayisi=0;
        sure=0;
        }
    }
    int tikalamaSayisi=0;
    int sure=0;
    PictureBox[] pbTiklanan=new PictureBox[2]; 
    public void pb_Clicked(Object sender,EventArgs e)
    {
        tikalamaSayisi++;
        if(tikalamaSayisi<3)
        {
            pbTiklanan[tikalamaSayisi-1]=(PictureBox) sender;
            pbTiklanan[tikalamaSayisi-1].BackColor=Color.Green;
        }
        if(tikalamaSayisi==2){
            tm.Start();
        }
        
    }

}
    
    
    
    public class pencerem
    {
        public static void Main(){
            Application.EnableVisualStyles(); //Windowsunuzun stiline uygun Pencere olması için...
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BenimPencerem());
        }    


    }
}