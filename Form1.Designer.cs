namespace Latih10_KonekDataBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnInsert = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            btnDelete = new Button();
            btnSave = new Button();
            panel2 = new Panel();
            radioPerempuan = new RadioButton();
            radioLaki = new RadioButton();
            txtKota = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtAlamat = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtTempatLahir = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            txtNIS = new TextBox();
            label3 = new Label();
            txtSiswaName = new TextBox();
            label2 = new Label();
            txtSiswaID = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(737, 495);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnInsert);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(729, 457);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "List Data";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(609, 406);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 34);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(713, 394);
            dataGridView1.TabIndex = 0;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightGray;
            tabPage2.Controls.Add(btnDelete);
            tabPage2.Controls.Add(btnSave);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(729, 457);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Input Data";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(490, 413);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(608, 413);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(radioPerempuan);
            panel2.Controls.Add(radioLaki);
            panel2.Controls.Add(txtKota);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtAlamat);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtTempatLahir);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(367, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 401);
            panel2.TabIndex = 6;
            // 
            // radioPerempuan
            // 
            radioPerempuan.AutoSize = true;
            radioPerempuan.Location = new Point(165, 157);
            radioPerempuan.Name = "radioPerempuan";
            radioPerempuan.Size = new Size(126, 29);
            radioPerempuan.TabIndex = 9;
            radioPerempuan.TabStop = true;
            radioPerempuan.Text = "Perempuan";
            radioPerempuan.UseVisualStyleBackColor = true;
            radioPerempuan.CheckedChanged += radioPerempuan_CheckedChanged;
            // 
            // radioLaki
            // 
            radioLaki.AutoSize = true;
            radioLaki.Location = new Point(34, 157);
            radioLaki.Name = "radioLaki";
            radioLaki.Size = new Size(104, 29);
            radioLaki.TabIndex = 8;
            radioLaki.TabStop = true;
            radioLaki.Text = "Laki-Laki";
            radioLaki.UseVisualStyleBackColor = true;
            radioLaki.CheckedChanged += radioLaki_CheckedChanged;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(17, 339);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(301, 31);
            txtKota.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(17, 84);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(301, 31);
            dateTimePicker1.TabIndex = 6;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(17, 259);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(301, 74);
            txtAlamat.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 231);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 4;
            label4.Text = "Alamat - Kota";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 129);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 2;
            label5.Text = "Gender";
            // 
            // txtTempatLahir
            // 
            txtTempatLahir.Location = new Point(17, 45);
            txtTempatLahir.Name = "txtTempatLahir";
            txtTempatLahir.Size = new Size(301, 31);
            txtTempatLahir.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 17);
            label6.Name = "label6";
            label6.Size = new Size(190, 25);
            label6.TabIndex = 0;
            label6.Text = "Tempat - Tanggal Lahir";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtNIS);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSiswaName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSiswaID);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(8, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 401);
            panel1.TabIndex = 0;
            // 
            // txtNIS
            // 
            txtNIS.Location = new Point(17, 176);
            txtNIS.Name = "txtNIS";
            txtNIS.Size = new Size(301, 31);
            txtNIS.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 148);
            label3.Name = "label3";
            label3.Size = new Size(211, 25);
            label3.TabIndex = 4;
            label3.Text = "Nomor Induk Siswa (NIS)";
            // 
            // txtSiswaName
            // 
            txtSiswaName.Location = new Point(17, 110);
            txtSiswaName.Name = "txtSiswaName";
            txtSiswaName.Size = new Size(301, 31);
            txtSiswaName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 82);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 2;
            label2.Text = "Siswa Name";
            // 
            // txtSiswaID
            // 
            txtSiswaID.Location = new Point(17, 45);
            txtSiswaID.Name = "txtSiswaID";
            txtSiswaID.Size = new Size(301, 31);
            txtSiswaID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 0;
            label1.Text = "Siswa ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 495);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel2;
        private DateTimePicker dateTimePicker1;
        private TextBox txtAlamat;
        private Label label4;
        private Label label5;
        private TextBox txtTempatLahir;
        private Label label6;
        private Panel panel1;
        private TextBox txtNIS;
        private Label label3;
        private TextBox txtSiswaName;
        private Label label2;
        private TextBox txtSiswaID;
        private Label label1;
        private Button btnInsert;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtKota;
        private RadioButton radioPerempuan;
        private RadioButton radioLaki;
    }
}
