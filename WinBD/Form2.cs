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
            // Загрузка таблицы данными:
            заказчикиTableAdapter1.Fill(rbProductDataSet1.Заказчики);
            // Настройка объекта DataView
            ЗаказчикиDataview = new DataView(rbProductDataSet1.Заказчики);
            // Настройка dataGridView для отображения данных
            dataGridView1.DataSource = ЗаказчикиDataview;
            // Присвоения исходного порядка сортировки
            ЗаказчикиDataview.Sort = "Фамилия";

        }

        private void button2_Click(object sender, EventArgs e)
        {
                 oleDbDataAdapter1.Update(rbProductDataSet1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ЗаказчикиDataview.Sort = SortTextBox.Text;
            ЗаказчикиDataview.RowFilter = FilterTextBox.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
