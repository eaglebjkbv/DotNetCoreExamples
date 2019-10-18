using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading;

namespace AsyncAwait2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        public Task<int> oyalanBakem(){
            
        return Task.Run(()=>
        {
            Thread.Sleep(5000);
            return 1;
        });
        }

        private async void buttonExit_Click(object sender, EventArgs e)
        {
           label1.Text="Lütfen Bekleyelim .....";
            await oyalanBakem();
            label1.Text="Bitti";
        }
    }
}
