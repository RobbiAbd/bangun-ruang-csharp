﻿namespace BangunRuang.forms
{
    partial class BalokForm
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
            this.textPanjang = new System.Windows.Forms.TextBox();
            this.textTinggi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textLebar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHasil = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHitung = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panjang";
            // 
            // textPanjang
            // 
            this.textPanjang.Location = new System.Drawing.Point(313, 108);
            this.textPanjang.Name = "textPanjang";
            this.textPanjang.Size = new System.Drawing.Size(100, 20);
            this.textPanjang.TabIndex = 1;
            // 
            // textTinggi
            // 
            this.textTinggi.Location = new System.Drawing.Point(313, 195);
            this.textTinggi.Name = "textTinggi";
            this.textTinggi.Size = new System.Drawing.Size(100, 20);
            this.textTinggi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tinggi";
            // 
            // textLebar
            // 
            this.textLebar.Location = new System.Drawing.Point(313, 150);
            this.textLebar.Name = "textLebar";
            this.textLebar.Size = new System.Drawing.Size(100, 20);
            this.textLebar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lebar";
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(377, 239);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(13, 13);
            this.labelHasil.TabIndex = 6;
            this.labelHasil.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hasil:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(337, 300);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 23);
            this.btnHitung.TabIndex = 8;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(12, 12);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(100, 23);
            this.btnKembali.TabIndex = 9;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // BalokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.textLebar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textTinggi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPanjang);
            this.Controls.Add(this.label1);
            this.Name = "BalokForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BalokForm";
            this.Load += new System.EventHandler(this.BalokForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPanjang;
        private System.Windows.Forms.TextBox textTinggi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLebar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Button btnKembali;
    }
}