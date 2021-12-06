using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAsynchMethod
{
    public partial class Form1 : Form
    {
        private delegate int AsyncSumm(int a, int b);
        public Form1()
        {
            InitializeComponent();
        }
        private int Summ(int a, int b)
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRun_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            AsyncSumm summdelegate = new AsyncSumm(Summ);
            AsyncCallback cb = new AsyncCallback(CallBackMethod);


        }
    }
}
