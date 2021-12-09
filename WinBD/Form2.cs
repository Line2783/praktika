using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataView ЗаказчикиDataview;
        private void button1_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Fill(dataSet11.Заказчики);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Update(dataSet11);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
