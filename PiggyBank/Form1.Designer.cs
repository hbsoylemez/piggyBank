namespace PiggyBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbParaTipi = new System.Windows.Forms.ComboBox();
            this.cmbMiktar = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnKır = new System.Windows.Forms.Button();
            this.btnSalla = new System.Windows.Forms.Button();
            this.btnYapıştır4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para Tipi :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Miktar     :";
            // 
            // cmbParaTipi
            // 
            this.cmbParaTipi.FormattingEnabled = true;
            this.cmbParaTipi.Location = new System.Drawing.Point(119, 157);
            this.cmbParaTipi.Name = "cmbParaTipi";
            this.cmbParaTipi.Size = new System.Drawing.Size(121, 24);
            this.cmbParaTipi.TabIndex = 4;
            this.cmbParaTipi.SelectedIndexChanged += new System.EventHandler(this.cmbParaTipi_SelectedIndexChanged);
            // 
            // cmbMiktar
            // 
            this.cmbMiktar.FormattingEnabled = true;
            this.cmbMiktar.Items.AddRange(new object[] {
            "0.1",
            "0.25",
            "0.50",
            "1",
            "5",
            "10",
            "20",
            "50",
            "100",
            "200"});
            this.cmbMiktar.Location = new System.Drawing.Point(119, 205);
            this.cmbMiktar.Name = "cmbMiktar";
            this.cmbMiktar.Size = new System.Drawing.Size(121, 24);
            this.cmbMiktar.TabIndex = 5;
            this.cmbMiktar.SelectedIndexChanged += new System.EventHandler(this.cmbMiktar_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(17, 252);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(96, 44);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnKır
            // 
            this.btnKır.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKır.Location = new System.Drawing.Point(17, 325);
            this.btnKır.Name = "btnKır";
            this.btnKır.Size = new System.Drawing.Size(96, 44);
            this.btnKır.TabIndex = 7;
            this.btnKır.Text = "Kır";
            this.btnKır.UseVisualStyleBackColor = true;
            this.btnKır.Click += new System.EventHandler(this.btnKır_Click);
            // 
            // btnSalla
            // 
            this.btnSalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalla.Location = new System.Drawing.Point(144, 252);
            this.btnSalla.Name = "btnSalla";
            this.btnSalla.Size = new System.Drawing.Size(96, 44);
            this.btnSalla.TabIndex = 8;
            this.btnSalla.Text = "Salla";
            this.btnSalla.UseVisualStyleBackColor = true;
            this.btnSalla.Click += new System.EventHandler(this.btnSalla_Click);
            // 
            // btnYapıştır4
            // 
            this.btnYapıştır4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYapıştır4.Location = new System.Drawing.Point(144, 325);
            this.btnYapıştır4.Name = "btnYapıştır4";
            this.btnYapıştır4.Size = new System.Drawing.Size(96, 44);
            this.btnYapıştır4.TabIndex = 9;
            this.btnYapıştır4.Text = "Yapıştır";
            this.btnYapıştır4.UseVisualStyleBackColor = true;
            this.btnYapıştır4.Click += new System.EventHandler(this.btnYapıştır4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYapıştır4);
            this.Controls.Add(this.btnSalla);
            this.Controls.Add(this.btnKır);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbMiktar);
            this.Controls.Add(this.cmbParaTipi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbParaTipi;
        private System.Windows.Forms.ComboBox cmbMiktar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnKır;
        private System.Windows.Forms.Button btnSalla;
        private System.Windows.Forms.Button btnYapıştır4;
    }
}

