
namespace Praktika
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отделLabel;
            this.конфетная_фабрикаDataSet = new Praktika.Конфетная_фабрикаDataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new Praktika.Конфетная_фабрикаDataSetTableAdapters.СотрудникиTableAdapter();
            this.tableAdapterManager = new Praktika.Конфетная_фабрикаDataSetTableAdapters.TableAdapterManager();
            this.FamtextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.SectiontextBox = new System.Windows.Forms.TextBox();
            this.Previousbutton = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отделLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.конфетная_фабрикаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // конфетная_фабрикаDataSet
            // 
            this.конфетная_фабрикаDataSet.DataSetName = "Конфетная_фабрикаDataSet";
            this.конфетная_фабрикаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.конфетная_фабрикаDataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Praktika.Конфетная_фабрикаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(47, 41);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(74, 17);
            фамилияLabel.TabIndex = 1;
            фамилияLabel.Text = "Фамилия:";
            // 
            // FamtextBox
            // 
            this.FamtextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Фамилия", true));
            this.FamtextBox.Location = new System.Drawing.Point(127, 38);
            this.FamtextBox.Name = "FamtextBox";
            this.FamtextBox.Size = new System.Drawing.Size(207, 22);
            this.FamtextBox.TabIndex = 2;
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(82, 68);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(39, 17);
            имяLabel.TabIndex = 2;
            имяLabel.Text = "Имя:";
            // 
            // NametextBox
            // 
            this.NametextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Имя", true));
            this.NametextBox.Location = new System.Drawing.Point(127, 65);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(207, 22);
            this.NametextBox.TabIndex = 3;
            // 
            // отделLabel
            // 
            отделLabel.AutoSize = true;
            отделLabel.Location = new System.Drawing.Point(67, 99);
            отделLabel.Name = "отделLabel";
            отделLabel.Size = new System.Drawing.Size(54, 17);
            отделLabel.TabIndex = 4;
            отделLabel.Text = "Отдел:";
            // 
            // SectiontextBox
            // 
            this.SectiontextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Отдел", true));
            this.SectiontextBox.Location = new System.Drawing.Point(127, 96);
            this.SectiontextBox.Name = "SectiontextBox";
            this.SectiontextBox.Size = new System.Drawing.Size(207, 22);
            this.SectiontextBox.TabIndex = 5;
            // 
            // Previousbutton
            // 
            this.Previousbutton.Location = new System.Drawing.Point(70, 154);
            this.Previousbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Previousbutton.Name = "Previousbutton";
            this.Previousbutton.Size = new System.Drawing.Size(100, 28);
            this.Previousbutton.TabIndex = 7;
            this.Previousbutton.Text = "Previous";
            this.Previousbutton.UseVisualStyleBackColor = true;
            this.Previousbutton.Click += new System.EventHandler(this.Previousbutton_Click);
            // 
            // Nextbutton
            // 
            this.Nextbutton.Location = new System.Drawing.Point(234, 154);
            this.Nextbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(100, 28);
            this.Nextbutton.TabIndex = 8;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 313);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.Previousbutton);
            this.Controls.Add(отделLabel);
            this.Controls.Add(this.SectiontextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.FamtextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.конфетная_фабрикаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Конфетная_фабрикаDataSet конфетная_фабрикаDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private Конфетная_фабрикаDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private Конфетная_фабрикаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox FamtextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox SectiontextBox;
        private System.Windows.Forms.Button Previousbutton;
        private System.Windows.Forms.Button Nextbutton;
    }
}

