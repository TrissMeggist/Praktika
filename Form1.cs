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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 Zadanie_4_4
        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.конфетная_фабрикаDataSet);

        }

        private void сотрудникиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.конфетная_фабрикаDataSet);

        }
        private BindingSource sotrBindingSource;
        private void Form1_Load(object sender, EventArgs e)
        {
            сотрудникиTableAdapter.Fill(конфетная_фабрикаDataSet.Сотрудники);
            sotrBindingSource = new BindingSource(конфетная_фабрикаDataSet, "Сотрудники");
            FamtextBox.DataBindings.Add("Text", sotrBindingSource, "Фамилия");
            NametextBox.DataBindings.Add("Text", sotrBindingSource, "Имя");
            SectiontextBox.DataBindings.Add("Text", sotrBindingSource, "Отдел");

        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            sotrBindingSource.MovePrevious();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            sotrBindingSource.MoveNext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "конфетная_фабрикаDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.конфетная_фабрикаDataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "конфетная_фабрикаDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.конфетная_фабрикаDataSet.Сотрудники);

        }

    

       

        
 Zadanie_4
    }
}
