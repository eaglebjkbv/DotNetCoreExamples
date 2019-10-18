using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int oyalanBakalim(){
            Thread.Sleep(10000);
            return 1;
           
        }
        private async void buttonExit_Click(object sender, EventArgs e)
        {
            Task<int> task=new Task<int>(oyalanBakalim);
            task.Start();

            label1.Text="Oyalanıyor Lütfen Bekleyiniz... ";
            await task;
            label1.Text="Bitti";

        }
    }
}
