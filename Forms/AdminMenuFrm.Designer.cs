
namespace PlanlamaOyunu.Forms
{
    partial class AdminMenuFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenuFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUrunOnayKaldir = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUrunOnayla = new System.Windows.Forms.Button();
            this.dtGrdViewUrunler = new System.Windows.Forms.DataGridView();
            this.cmbBoxUrunFiltre = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTalepListeYenile = new System.Windows.Forms.Button();
            this.btnParaOnayiRet = new System.Windows.Forms.Button();
            this.btnParaOnayla = new System.Windows.Forms.Button();
            this.dtGrdViewParalar = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewUrunler)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewParalar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(889, 508);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUrunOnayKaldir);
            this.tabPage1.Controls.Add(this.btnUrunOnayla);
            this.tabPage1.Controls.Add(this.dtGrdViewUrunler);
            this.tabPage1.Controls.Add(this.cmbBoxUrunFiltre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(881, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürünler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUrunOnayKaldir
            // 
            this.btnUrunOnayKaldir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunOnayKaldir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunOnayKaldir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunOnayKaldir.ImageKey = "delete_96px.png";
            this.btnUrunOnayKaldir.ImageList = this.ımageList1;
            this.btnUrunOnayKaldir.Location = new System.Drawing.Point(700, 6);
            this.btnUrunOnayKaldir.Name = "btnUrunOnayKaldir";
            this.btnUrunOnayKaldir.Size = new System.Drawing.Size(178, 29);
            this.btnUrunOnayKaldir.TabIndex = 4;
            this.btnUrunOnayKaldir.Text = "Ürünü Onayı Kaldır";
            this.btnUrunOnayKaldir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunOnayKaldir.UseVisualStyleBackColor = true;
            this.btnUrunOnayKaldir.Click += new System.EventHandler(this.btnUrunOnayKaldir_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "synchronize_96px(mavi).png");
            this.ımageList1.Images.SetKeyName(1, "checkmark_96px.png");
            this.ımageList1.Images.SetKeyName(2, "delete_96px.png");
            // 
            // btnUrunOnayla
            // 
            this.btnUrunOnayla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunOnayla.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunOnayla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunOnayla.ImageKey = "checkmark_96px.png";
            this.btnUrunOnayla.ImageList = this.ımageList1;
            this.btnUrunOnayla.Location = new System.Drawing.Point(550, 6);
            this.btnUrunOnayla.Name = "btnUrunOnayla";
            this.btnUrunOnayla.Size = new System.Drawing.Size(144, 29);
            this.btnUrunOnayla.TabIndex = 3;
            this.btnUrunOnayla.Text = "Ürünü Onayla";
            this.btnUrunOnayla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunOnayla.UseVisualStyleBackColor = true;
            this.btnUrunOnayla.Click += new System.EventHandler(this.btnUrunOnayla_Click);
            // 
            // dtGrdViewUrunler
            // 
            this.dtGrdViewUrunler.AllowUserToAddRows = false;
            this.dtGrdViewUrunler.AllowUserToDeleteRows = false;
            this.dtGrdViewUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdViewUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewUrunler.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdViewUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrdViewUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrdViewUrunler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrdViewUrunler.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dtGrdViewUrunler.Location = new System.Drawing.Point(0, 41);
            this.dtGrdViewUrunler.MultiSelect = false;
            this.dtGrdViewUrunler.Name = "dtGrdViewUrunler";
            this.dtGrdViewUrunler.ReadOnly = true;
            this.dtGrdViewUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewUrunler.Size = new System.Drawing.Size(881, 441);
            this.dtGrdViewUrunler.TabIndex = 1;
            // 
            // cmbBoxUrunFiltre
            // 
            this.cmbBoxUrunFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxUrunFiltre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxUrunFiltre.FormattingEnabled = true;
            this.cmbBoxUrunFiltre.Items.AddRange(new object[] {
            "Hepsi",
            "Onaylanmamış Ürünler",
            "Onaylanmış Ürünler"});
            this.cmbBoxUrunFiltre.Location = new System.Drawing.Point(3, 6);
            this.cmbBoxUrunFiltre.Name = "cmbBoxUrunFiltre";
            this.cmbBoxUrunFiltre.Size = new System.Drawing.Size(225, 27);
            this.cmbBoxUrunFiltre.TabIndex = 0;
            this.cmbBoxUrunFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbBoxUrunFiltre_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTalepListeYenile);
            this.tabPage2.Controls.Add(this.btnParaOnayiRet);
            this.tabPage2.Controls.Add(this.btnParaOnayla);
            this.tabPage2.Controls.Add(this.dtGrdViewParalar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(881, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Para Talepleri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTalepListeYenile
            // 
            this.btnTalepListeYenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTalepListeYenile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTalepListeYenile.ImageKey = "synchronize_96px(mavi).png";
            this.btnTalepListeYenile.ImageList = this.ımageList1;
            this.btnTalepListeYenile.Location = new System.Drawing.Point(8, 6);
            this.btnTalepListeYenile.Name = "btnTalepListeYenile";
            this.btnTalepListeYenile.Size = new System.Drawing.Size(36, 29);
            this.btnTalepListeYenile.TabIndex = 7;
            this.btnTalepListeYenile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTalepListeYenile.UseVisualStyleBackColor = true;
            this.btnTalepListeYenile.Click += new System.EventHandler(this.btnTalepListeYenile_Click);
            // 
            // btnParaOnayiRet
            // 
            this.btnParaOnayiRet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParaOnayiRet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParaOnayiRet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParaOnayiRet.ImageKey = "delete_96px.png";
            this.btnParaOnayiRet.ImageList = this.ımageList1;
            this.btnParaOnayiRet.Location = new System.Drawing.Point(683, 6);
            this.btnParaOnayiRet.Name = "btnParaOnayiRet";
            this.btnParaOnayiRet.Size = new System.Drawing.Size(190, 29);
            this.btnParaOnayiRet.TabIndex = 6;
            this.btnParaOnayiRet.Text = "Para Talebini Reddet";
            this.btnParaOnayiRet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnParaOnayiRet.UseVisualStyleBackColor = true;
            this.btnParaOnayiRet.Click += new System.EventHandler(this.btnParaOnayiRet_Click);
            // 
            // btnParaOnayla
            // 
            this.btnParaOnayla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParaOnayla.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParaOnayla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParaOnayla.ImageKey = "checkmark_96px.png";
            this.btnParaOnayla.ImageList = this.ımageList1;
            this.btnParaOnayla.Location = new System.Drawing.Point(483, 6);
            this.btnParaOnayla.Name = "btnParaOnayla";
            this.btnParaOnayla.Size = new System.Drawing.Size(194, 29);
            this.btnParaOnayla.TabIndex = 5;
            this.btnParaOnayla.Text = "Para Talebini Onayla";
            this.btnParaOnayla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnParaOnayla.UseVisualStyleBackColor = true;
            this.btnParaOnayla.Click += new System.EventHandler(this.btnParaOnayla_Click);
            // 
            // dtGrdViewParalar
            // 
            this.dtGrdViewParalar.AllowUserToAddRows = false;
            this.dtGrdViewParalar.AllowUserToDeleteRows = false;
            this.dtGrdViewParalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewParalar.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdViewParalar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGrdViewParalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrdViewParalar.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtGrdViewParalar.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dtGrdViewParalar.Location = new System.Drawing.Point(0, 41);
            this.dtGrdViewParalar.MultiSelect = false;
            this.dtGrdViewParalar.Name = "dtGrdViewParalar";
            this.dtGrdViewParalar.ReadOnly = true;
            this.dtGrdViewParalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewParalar.Size = new System.Drawing.Size(881, 441);
            this.dtGrdViewParalar.TabIndex = 2;
            // 
            // AdminMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 508);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminMenuFrm";
            this.Text = "AdminMenuFrm";
            this.Load += new System.EventHandler(this.AdminMenuFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewUrunler)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewParalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbBoxUrunFiltre;
        private System.Windows.Forms.DataGridView dtGrdViewUrunler;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnUrunOnayla;
        private System.Windows.Forms.Button btnUrunOnayKaldir;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtGrdViewParalar;
        private System.Windows.Forms.Button btnParaOnayiRet;
        private System.Windows.Forms.Button btnParaOnayla;
        private System.Windows.Forms.Button btnTalepListeYenile;
    }
}