
namespace WindowsFormsApp1
{
    partial class KitapEkleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtKitapAdi = new System.Windows.Forms.TextBox();
            this.TxtBolumveRaf = new System.Windows.Forms.TextBox();
            this.TxtYazarAdi = new System.Windows.Forms.TextBox();
            this.BtnKitapEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazar Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bölüm ve Raf No:";
            // 
            // TxtKitapAdi
            // 
            this.TxtKitapAdi.Location = new System.Drawing.Point(161, 89);
            this.TxtKitapAdi.Name = "TxtKitapAdi";
            this.TxtKitapAdi.Size = new System.Drawing.Size(100, 20);
            this.TxtKitapAdi.TabIndex = 3;
            // 
            // TxtBolumveRaf
            // 
            this.TxtBolumveRaf.Location = new System.Drawing.Point(161, 161);
            this.TxtBolumveRaf.Name = "TxtBolumveRaf";
            this.TxtBolumveRaf.Size = new System.Drawing.Size(100, 20);
            this.TxtBolumveRaf.TabIndex = 4;
            // 
            // TxtYazarAdi
            // 
            this.TxtYazarAdi.Location = new System.Drawing.Point(161, 126);
            this.TxtYazarAdi.Name = "TxtYazarAdi";
            this.TxtYazarAdi.Size = new System.Drawing.Size(100, 20);
            this.TxtYazarAdi.TabIndex = 5;
            // 
            // BtnKitapEkle
            // 
            this.BtnKitapEkle.Location = new System.Drawing.Point(161, 210);
            this.BtnKitapEkle.Name = "BtnKitapEkle";
            this.BtnKitapEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnKitapEkle.TabIndex = 6;
            this.BtnKitapEkle.Text = "Ekle";
            this.BtnKitapEkle.UseVisualStyleBackColor = true;
            this.BtnKitapEkle.Click += new System.EventHandler(this.BtnKitapEkle_Click);
            // 
            // KitapEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(375, 281);
            this.Controls.Add(this.BtnKitapEkle);
            this.Controls.Add(this.TxtYazarAdi);
            this.Controls.Add(this.TxtBolumveRaf);
            this.Controls.Add(this.TxtKitapAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KitapEkleForm";
            this.Text = "KitapEkleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtKitapAdi;
        private System.Windows.Forms.TextBox TxtBolumveRaf;
        private System.Windows.Forms.TextBox TxtYazarAdi;
        private System.Windows.Forms.Button BtnKitapEkle;
    }
}