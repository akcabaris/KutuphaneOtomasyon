
namespace WindowsFormsApp1
{
    partial class KitapDuzenleForm
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
            this.TxtYazarAdi = new System.Windows.Forms.TextBox();
            this.BtnKtpDuzenle = new System.Windows.Forms.Button();
            this.TxtBolumRaf = new System.Windows.Forms.TextBox();
            this.TxtKitapAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtYazarAdi
            // 
            this.TxtYazarAdi.Location = new System.Drawing.Point(113, 181);
            this.TxtYazarAdi.Name = "TxtYazarAdi";
            this.TxtYazarAdi.Size = new System.Drawing.Size(100, 20);
            this.TxtYazarAdi.TabIndex = 15;
            // 
            // BtnKtpDuzenle
            // 
            this.BtnKtpDuzenle.Location = new System.Drawing.Point(99, 289);
            this.BtnKtpDuzenle.Name = "BtnKtpDuzenle";
            this.BtnKtpDuzenle.Size = new System.Drawing.Size(75, 23);
            this.BtnKtpDuzenle.TabIndex = 14;
            this.BtnKtpDuzenle.Text = "Güncele";
            this.BtnKtpDuzenle.UseVisualStyleBackColor = true;
            this.BtnKtpDuzenle.Click += new System.EventHandler(this.BtnKtpEkle_Click);
            // 
            // TxtBolumRaf
            // 
            this.TxtBolumRaf.Location = new System.Drawing.Point(113, 218);
            this.TxtBolumRaf.Name = "TxtBolumRaf";
            this.TxtBolumRaf.Size = new System.Drawing.Size(100, 20);
            this.TxtBolumRaf.TabIndex = 13;
            // 
            // TxtKitapAdi
            // 
            this.TxtKitapAdi.Location = new System.Drawing.Point(113, 143);
            this.TxtKitapAdi.Name = "TxtKitapAdi";
            this.TxtKitapAdi.Size = new System.Drawing.Size(100, 20);
            this.TxtKitapAdi.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bölüm ve Raf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Yazar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kitap Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(25)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(250, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(517, 223);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // KitapDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtYazarAdi);
            this.Controls.Add(this.BtnKtpDuzenle);
            this.Controls.Add(this.TxtBolumRaf);
            this.Controls.Add(this.TxtKitapAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitapDuzenleForm";
            this.Text = "KitapDuzenleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KitapDuzenleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtYazarAdi;
        private System.Windows.Forms.Button BtnKtpDuzenle;
        private System.Windows.Forms.TextBox TxtBolumRaf;
        private System.Windows.Forms.TextBox TxtKitapAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}