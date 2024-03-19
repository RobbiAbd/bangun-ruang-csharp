using BangunRuang.controllers;
using BangunRuang.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BangunRuang.Forms
{
    public partial class BolaForm : Form
    {
        public BolaForm()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm form = new HomeForm();
            form.Show();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            labelHasil.Text = "?";
            Helper helper = new Helper();

            if (!helper.checkIsEmpty(textJariJari))
            {
                MessageBox.Show("Inputan tidak boleh kosong!", "Alert");
                return;
            }

            if (!helper.checkIsNumber(textJariJari))
            {
                MessageBox.Show("Inputan hanya boleh angka!", "Alert");
                return;
            }

            Bola bola = new Bola();
            int jariJari = int.Parse(textJariJari.Text);
            bola.volume = jariJari;

            labelHasil.Text = bola.volume.ToString();
        }
    }
}
