namespace sinemaörneği
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.labelkoltukno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxadsoyad = new System.Windows.Forms.TextBox();
            this.gösterbtn = new System.Windows.Forms.Button();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxücret = new System.Windows.Forms.TextBox();
            this.radioogrenci = new System.Windows.Forms.RadioButton();
            this.radiocalısan = new System.Windows.Forms.RadioButton();
            this.buttonücret = new System.Windows.Forms.Button();
            this.textBoxkisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Highlight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.Location = new System.Drawing.Point(-2, 346);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(493, 149);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sırano:";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "adsoyad";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "cinsiyet";
            this.columnHeader3.Width = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(549, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "koltukno:";
            // 
            // labelkoltukno
            // 
            this.labelkoltukno.AutoSize = true;
            this.labelkoltukno.Location = new System.Drawing.Point(677, 73);
            this.labelkoltukno.Name = "labelkoltukno";
            this.labelkoltukno.Size = new System.Drawing.Size(24, 17);
            this.labelkoltukno.TabIndex = 2;
            this.labelkoltukno.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(549, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "adsoyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(549, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "cinsiyet:";
            // 
            // textBoxadsoyad
            // 
            this.textBoxadsoyad.Location = new System.Drawing.Point(660, 127);
            this.textBoxadsoyad.Name = "textBoxadsoyad";
            this.textBoxadsoyad.Size = new System.Drawing.Size(148, 22);
            this.textBoxadsoyad.TabIndex = 5;
            // 
            // gösterbtn
            // 
            this.gösterbtn.Location = new System.Drawing.Point(552, 346);
            this.gösterbtn.Name = "gösterbtn";
            this.gösterbtn.Size = new System.Drawing.Size(102, 42);
            this.gösterbtn.TabIndex = 8;
            this.gösterbtn.Text = "Göster";
            this.gösterbtn.UseVisualStyleBackColor = true;
            this.gösterbtn.Click += new System.EventHandler(this.gösterbtn_Click);
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(660, 346);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(102, 42);
            this.kaydetbtn.TabIndex = 9;
            this.kaydetbtn.Text = "kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "erkek",
            "kadın"});
            this.comboBox1.Location = new System.Drawing.Point(660, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ücret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(555, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "ücret:";
            // 
            // textBoxücret
            // 
            this.textBoxücret.Location = new System.Drawing.Point(633, 291);
            this.textBoxücret.Name = "textBoxücret";
            this.textBoxücret.Size = new System.Drawing.Size(148, 22);
            this.textBoxücret.TabIndex = 12;
            // 
            // radioogrenci
            // 
            this.radioogrenci.AutoSize = true;
            this.radioogrenci.Location = new System.Drawing.Point(633, 217);
            this.radioogrenci.Name = "radioogrenci";
            this.radioogrenci.Size = new System.Drawing.Size(76, 21);
            this.radioogrenci.TabIndex = 13;
            this.radioogrenci.TabStop = true;
            this.radioogrenci.Text = "öğrenci";
            this.radioogrenci.UseVisualStyleBackColor = true;
            // 
            // radiocalısan
            // 
            this.radiocalısan.AutoSize = true;
            this.radiocalısan.Location = new System.Drawing.Point(715, 217);
            this.radiocalısan.Name = "radiocalısan";
            this.radiocalısan.Size = new System.Drawing.Size(73, 21);
            this.radiocalısan.TabIndex = 14;
            this.radiocalısan.TabStop = true;
            this.radiocalısan.Text = "çalışan";
            this.radiocalısan.UseVisualStyleBackColor = true;
            // 
            // buttonücret
            // 
            this.buttonücret.Location = new System.Drawing.Point(768, 346);
            this.buttonücret.Name = "buttonücret";
            this.buttonücret.Size = new System.Drawing.Size(102, 42);
            this.buttonücret.TabIndex = 15;
            this.buttonücret.Text = "ücret";
            this.buttonücret.UseVisualStyleBackColor = true;
            this.buttonücret.Click += new System.EventHandler(this.buttonücret_Click);
            // 
            // textBoxkisi
            // 
            this.textBoxkisi.Location = new System.Drawing.Point(634, 253);
            this.textBoxkisi.Name = "textBoxkisi";
            this.textBoxkisi.Size = new System.Drawing.Size(76, 22);
            this.textBoxkisi.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(533, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "kişisayısı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(873, 492);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxkisi);
            this.Controls.Add(this.buttonücret);
            this.Controls.Add(this.radiocalısan);
            this.Controls.Add(this.radioogrenci);
            this.Controls.Add(this.textBoxücret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.kaydetbtn);
            this.Controls.Add(this.gösterbtn);
            this.Controls.Add(this.textBoxadsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelkoltukno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelkoltukno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxadsoyad;
        private System.Windows.Forms.Button gösterbtn;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxücret;
        private System.Windows.Forms.RadioButton radioogrenci;
        private System.Windows.Forms.RadioButton radiocalısan;
        private System.Windows.Forms.Button buttonücret;
        private System.Windows.Forms.TextBox textBoxkisi;
        private System.Windows.Forms.Label label5;
    }
}

