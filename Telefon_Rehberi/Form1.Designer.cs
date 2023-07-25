namespace Telefon_Rehberi
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            btnTemizle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            txtMail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtSoyad = new TextBox();
            label3 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            btnEkle = new Button();
            mskTelefon = new MaskedTextBox();
            txtID = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(490, 294);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rehber";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(484, 268);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTemizle);
            groupBox2.Controls.Add(btnGuncelle);
            groupBox2.Controls.Add(btnSil);
            groupBox2.Controls.Add(txtMail);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtSoyad);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtAd);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnEkle);
            groupBox2.Controls.Add(mskTelefon);
            groupBox2.Controls.Add(txtID);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(508, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(249, 294);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yeni Kişi";
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(132, 237);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(101, 29);
            btnTemizle.TabIndex = 8;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(25, 237);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(101, 29);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(132, 202);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(101, 29);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.AntiqueWhite;
            txtMail.Location = new Point(90, 169);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(143, 27);
            txtMail.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 172);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 999;
            label5.Text = "Mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 139);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 888;
            label4.Text = "Telefon: ";
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.AntiqueWhite;
            txtSoyad.Location = new Point(90, 103);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(143, 27);
            txtSoyad.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 106);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 666;
            label3.Text = "Soyad:";
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.AntiqueWhite;
            txtAd.Location = new Point(90, 70);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(143, 27);
            txtAd.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 73);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 444;
            label2.Text = "Ad:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(25, 202);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(101, 29);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // mskTelefon
            // 
            mskTelefon.BackColor = Color.AntiqueWhite;
            mskTelefon.Location = new Point(90, 136);
            mskTelefon.Mask = "(999) 000-0000";
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(143, 27);
            mskTelefon.TabIndex = 2;
            // 
            // txtID
            // 
            txtID.BackColor = Color.AntiqueWhite;
            txtID.Enabled = false;
            txtID.Location = new Point(90, 37);
            txtID.Name = "txtID";
            txtID.Size = new Size(143, 27);
            txtID.TabIndex = 369;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 40);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 111;
            label1.Text = "ID:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(769, 318);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Telefon Rehberi";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnTemizle;
        private Button btnGuncelle;
        private Button btnSil;
        private TextBox txtMail;
        private Label label5;
        private Label label4;
        private TextBox txtSoyad;
        private Label label3;
        private TextBox txtAd;
        private Label label2;
        private Button btnEkle;
        private MaskedTextBox mskTelefon;
        private TextBox txtID;
    }
}