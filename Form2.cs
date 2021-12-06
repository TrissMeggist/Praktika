using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        DataView ЗаказчикиDataView;

        private void button1_Click(object sender, EventArgs e)
        {
            заказчикиTableAdapter1.Fill(конфетная_фабрикаDataSet1.Заказчики);
            ЗаказчикиDataView = new DataView(конфетная_фабрикаDataSet1.Заказчики);
            dataGridView1.DataSource = ЗаказчикиDataView;
            ЗаказчикиDataView.Sort = "Фамилия";
        }

            private void button2_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Update(конфетная_фабрикаDataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ЗаказчикиDataView.Sort = SortTextBox.Text;
            ЗаказчикиDataView.RowFilter = FilterTextBox.Text;
        }
    }
}
