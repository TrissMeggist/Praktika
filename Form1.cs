﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Praktika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 Zadanie_3

 Zadanie_2
 Zadanie_2_3
 master
        private delegate int AsyncSumm(int a, int b);
        private int Summ(int a, int b)
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int a, b;

            try
            {
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                txbA.Text = txbB.Text = "";
                return;
            }

            AsyncSumm summdelegate = new AsyncSumm(Summ);
            AsyncCallback cb = new AsyncCallback(CallBackMethod);
            summdelegate.BeginInvoke(a, b, cb, summdelegate);
        }

        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
            str = String.Format("Сумма введенных чисел равна {0}", summdelegate.EndInvoke(ar));
            MessageBox.Show(str, "Результат операции");
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работа кипит!!!");
 Zadanie_3
        }
 Zadanie_3_3

 Zadanie_3_2

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);

        }

 Zadanie_3
 Zadanie_3


 Zadanie_2_2
        bool Cancel;

        private delegate void TimeConsumingMethodDelegate(int seconds);
        private void TimeConsumingMethod(int seconds)
        {
            for (int j = 1; j <= seconds; j++)
            {
                SetProgress((int)(j * 100 / seconds));
                if (Cancel)
                    break;
                System.Threading.Thread.Sleep(1000);
            }
            if (Cancel)
            {
                System.Windows.Forms.MessageBox.Show("Cancelled");
                Cancel = false;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Complete");
            }
        }
        public delegate void SerProgressDelegate(int val);
        public void SetProgress(int val)
        {
            if (progressBar1.InvokeRequired)
            {
                SerProgressDelegate del = new SerProgressDelegate(SetProgress);
                this.Invoke(del, new object[] { val });
            }
            else
            {
                progressBar1.Value = val;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать только цифры");
            }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int i;
            i = int.Parse(e.Argument.ToString());
            for (int j = 1; j <= i; j++)
            {
                if (backgroundWorker1.CancellationPending)

                {
                    e.Cancel = true;
                    return;
                }
                System.Threading.Thread.Sleep(1000);
                backgroundWorker1.ReportProgress((int)(j * 100 / i));
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!(e.Cancelled))
                System.Windows.Forms.MessageBox.Show("Run Completed!");
            else
                System.Windows.Forms.MessageBox.Show("Run Cancelled");
 Zadanie_2
        }

        private void button1_Click(object sender, EventArgs e)
        {
 Zadanie_2_2
            TimeConsumingMethodDelegate del = new TimeConsumingMethodDelegate(TimeConsumingMethod);
            del.BeginInvoke(int.Parse(textBox1.Text), null, null);

            if (!(textBox1.Text == ""))
            {
                int i = int.Parse(textBox1.Text);
                backgroundWorker1.RunWorkerAsync(i);
            }
 Zadanie_2
        }

        private void button2_Click(object sender, EventArgs e)
        {
 Zadanie_2_2
            Cancel = true;

            backgroundWorker1.CancelAsync();
 Zadanie_2
 Zadanie_2

 Zadanie_1_2
        private void btnAW_BLEND_Click(object sender, EventArgs e)
        {
            // Скрываем окно
            this.Hide();
            // Запускаем анимацию. Второй параметр в скобках - время анимации в миллисекундах.
            WinAPIClass.AnimateWindow(this, 3000, WinAPIClass.AnimateWindowFlags.AW_ACTIVATE | WinAPIClass.AnimateWindowFlags.AW_BLEND);
            // Отображаем кнопки после анимации
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();
        }

        private void btnHOR_AW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 3000, WinAPIClass.AnimateWindowFlags.AW_HOR_POSITIVE | WinAPIClass.AnimateWindowFlags.AW_SLIDE);
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();
        }

        private void btnCenter_AW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 3000, WinAPIClass.AnimateWindowFlags.AW_CENTER | WinAPIClass.AnimateWindowFlags.AW_SLIDE);
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Файлы pdf|*.pdf";
            openFileDialog1.ShowDialog();
            axAcroPDF1.LoadFile(openFileDialog1.FileName);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
 Zadanie_1
 master
        }
 master
    }
}
