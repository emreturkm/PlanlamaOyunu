
namespace PlanlamaOyunu.Forms
{
    partial class SaticiMenuFrm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbBoxUrunIsmi = new System.Windows.Forms.ComboBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtBoxUrunKgFiyat = new System.Windows.Forms.TextBox();
            this.txtBoxUrunKilo = new System.Windows.Forms.TextBox();
            this.txtBoxUrunIsmi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(819, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürünlerim";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(813, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbBoxUrunIsmi);
            this.tabPage2.Controls.Add(this.btnUrunEkle);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.txtBoxUrunKgFiyat);
            this.tabPage2.Controls.Add(this.txtBoxUrunKilo);
            this.tabPage2.Controls.Add(this.txtBoxUrunIsmi);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(819, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yeni Ürün";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbBoxUrunIsmi
            // 
            this.cmbBoxUrunIsmi.FormattingEnabled = true;
            this.cmbBoxUrunIsmi.Items.AddRange(new object[] {
            "Buğday",
            "Pirinç",
            "Arpa",
            "Yulaf",
            "Petrol",
            "Pamuk",
            "Diğer"});
            this.cmbBoxUrunIsmi.Location = new System.Drawing.Point(99, 10);
            this.cmbBoxUrunIsmi.Name = "cmbBoxUrunIsmi";
            this.cmbBoxUrunIsmi.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxUrunIsmi.TabIndex = 8;
            this.cmbBoxUrunIsmi.SelectedIndexChanged += new System.EventHandler(this.cmbBoxUrunIsmi_SelectedIndexChanged);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(205, 64);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(121, 20);
            this.btnUrunEkle.TabIndex = 7;
            this.btnUrunEkle.Text = "Ürün Talebi Oluştur";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 87);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(807, 318);
            this.dataGridView2.TabIndex = 6;
            // 
            // txtBoxUrunKgFiyat
            // 
            this.txtBoxUrunKgFiyat.Location = new System.Drawing.Point(99, 64);
            this.txtBoxUrunKgFiyat.Name = "txtBoxUrunKgFiyat";
            this.txtBoxUrunKgFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUrunKgFiyat.TabIndex = 5;
            // 
            // txtBoxUrunKilo
            // 
            this.txtBoxUrunKilo.Location = new System.Drawing.Point(99, 37);
            this.txtBoxUrunKilo.Name = "txtBoxUrunKilo";
            this.txtBoxUrunKilo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUrunKilo.TabIndex = 4;
            // 
            // txtBoxUrunIsmi
            // 
            this.txtBoxUrunIsmi.Location = new System.Drawing.Point(226, 10);
            this.txtBoxUrunIsmi.Name = "txtBoxUrunIsmi";
            this.txtBoxUrunIsmi.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUrunIsmi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Kg fiyatı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün kilosu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün ismi:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(819, 413);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Siparişler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(813, 407);
            this.dataGridView3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ürünü Kaldır";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SaticiMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 439);
            this.Controls.Add(this.tabControl1);
            this.Name = "SaticiMenuFrm";
            this.Text = "SaticiMenuFrm";
            this.Load += new System.EventHandler(this.SaticiMenuFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxUrunKgFiyat;
        private System.Windows.Forms.TextBox txtBoxUrunKilo;
        private System.Windows.Forms.TextBox txtBoxUrunIsmi;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox cmbBoxUrunIsmi;
        private System.Windows.Forms.Button button1;
    }
}