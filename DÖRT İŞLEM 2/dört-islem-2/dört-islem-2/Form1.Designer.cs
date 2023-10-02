namespace dört_islem_2
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblFark = new System.Windows.Forms.Label();
            this.lblCarpim = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.lblBolum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.LightCoral;
            this.btnHesapla.Location = new System.Drawing.Point(103, 174);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 43);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi1.Location = new System.Drawing.Point(29, 69);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(56, 20);
            this.lblSayi1.TabIndex = 1;
            this.lblSayi1.Text = "1.Sayı:";
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi2.Location = new System.Drawing.Point(29, 110);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(56, 20);
            this.lblSayi2.TabIndex = 2;
            this.lblSayi2.Text = "2.Sayı:";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(265, 61);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(65, 20);
            this.lblToplam.TabIndex = 3;
            this.lblToplam.Text = "Toplam:";
            // 
            // lblFark
            // 
            this.lblFark.AutoSize = true;
            this.lblFark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFark.Location = new System.Drawing.Point(265, 98);
            this.lblFark.Name = "lblFark";
            this.lblFark.Size = new System.Drawing.Size(45, 20);
            this.lblFark.TabIndex = 5;
            this.lblFark.Text = "Fark:";
            // 
            // lblCarpim
            // 
            this.lblCarpim.AutoSize = true;
            this.lblCarpim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCarpim.Location = new System.Drawing.Point(260, 137);
            this.lblCarpim.Name = "lblCarpim";
            this.lblCarpim.Size = new System.Drawing.Size(63, 20);
            this.lblCarpim.TabIndex = 4;
            this.lblCarpim.Text = "Çarpım:";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(103, 66);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 6;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(103, 110);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 7;
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolum.Location = new System.Drawing.Point(260, 177);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(58, 20);
            this.lblBolum.TabIndex = 8;
            this.lblBolum.Text = "Bölüm:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.lblBolum);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.lblFark);
            this.Controls.Add(this.lblCarpim);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblSayi1);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblFark;
        private System.Windows.Forms.Label lblCarpim;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label lblBolum;
    }
}

