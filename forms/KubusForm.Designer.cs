namespace BangunRuang.forms
{
    partial class KubusForm
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
            this.textSisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHitung = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHasil = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textSisi
            // 
            this.textSisi.Location = new System.Drawing.Point(345, 128);
            this.textSisi.Name = "textSisi";
            this.textSisi.Size = new System.Drawing.Size(100, 20);
            this.textSisi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sisi";
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(345, 202);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(100, 23);
            this.btnHitung.TabIndex = 2;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasil:";
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(412, 166);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(13, 13);
            this.labelHasil.TabIndex = 4;
            this.labelHasil.Text = "?";
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(12, 12);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(100, 23);
            this.btnKembali.TabIndex = 5;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // KubusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSisi);
            this.Name = "KubusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KubusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Button btnKembali;
    }
}