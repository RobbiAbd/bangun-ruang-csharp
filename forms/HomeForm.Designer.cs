namespace BangunRuang
{
    partial class HomeForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnKubus = new System.Windows.Forms.Button();
            this.btnBalok = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnKerucut = new System.Windows.Forms.Button();
            this.btnBola = new System.Windows.Forms.Button();
            this.btnTabung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(349, 301);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnKubus
            // 
            this.btnKubus.Location = new System.Drawing.Point(198, 78);
            this.btnKubus.Name = "btnKubus";
            this.btnKubus.Size = new System.Drawing.Size(104, 23);
            this.btnKubus.TabIndex = 1;
            this.btnKubus.Text = "Hitung Kubus";
            this.btnKubus.UseVisualStyleBackColor = true;
            this.btnKubus.Click += new System.EventHandler(this.btnKubus_Click);
            // 
            // btnBalok
            // 
            this.btnBalok.Location = new System.Drawing.Point(339, 78);
            this.btnBalok.Name = "btnBalok";
            this.btnBalok.Size = new System.Drawing.Size(104, 23);
            this.btnBalok.TabIndex = 2;
            this.btnBalok.Text = "Hitung Balok";
            this.btnBalok.UseVisualStyleBackColor = true;
            this.btnBalok.Click += new System.EventHandler(this.btnBalok_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 425);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(253, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/RobbiAbd/bangun-ruang-csharp";
            // 
            // btnKerucut
            // 
            this.btnKerucut.Location = new System.Drawing.Point(490, 78);
            this.btnKerucut.Name = "btnKerucut";
            this.btnKerucut.Size = new System.Drawing.Size(104, 23);
            this.btnKerucut.TabIndex = 4;
            this.btnKerucut.Text = "Hitung Kerucut";
            this.btnKerucut.UseVisualStyleBackColor = true;
            this.btnKerucut.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBola
            // 
            this.btnBola.Location = new System.Drawing.Point(263, 148);
            this.btnBola.Name = "btnBola";
            this.btnBola.Size = new System.Drawing.Size(104, 23);
            this.btnBola.TabIndex = 5;
            this.btnBola.Text = "Hitung Bola";
            this.btnBola.UseVisualStyleBackColor = true;
            this.btnBola.Click += new System.EventHandler(this.btnBola_Click);
            // 
            // btnTabung
            // 
            this.btnTabung.Location = new System.Drawing.Point(422, 148);
            this.btnTabung.Name = "btnTabung";
            this.btnTabung.Size = new System.Drawing.Size(104, 23);
            this.btnTabung.TabIndex = 6;
            this.btnTabung.Text = "Hitung Tabung";
            this.btnTabung.UseVisualStyleBackColor = true;
            this.btnTabung.Click += new System.EventHandler(this.btnTabung_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTabung);
            this.Controls.Add(this.btnBola);
            this.Controls.Add(this.btnKerucut);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnBalok);
            this.Controls.Add(this.btnKubus);
            this.Controls.Add(this.btnExit);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robbi - 40622200023";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnKubus;
        private System.Windows.Forms.Button btnBalok;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnKerucut;
        private System.Windows.Forms.Button btnBola;
        private System.Windows.Forms.Button btnTabung;
    }
}

