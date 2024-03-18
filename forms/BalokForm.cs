using BangunRuang.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BangunRuang.forms
{
    public partial class BalokForm : Form
    {
        public BalokForm()
        {
            InitializeComponent();
        }

        private void BalokForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            labelHasil.Text = "?";
            Helper helper = new Helper();

            if (!helper.checkIsEmpty(textPanjang) || !helper.checkIsEmpty(textLebar) || !helper.checkIsEmpty(textTinggi))
            {
                MessageBox.Show("Inputan tidak boleh kosong!", "Alert");
                return;
            }

            if (!helper.checkIsNumber(textPanjang) || !helper.checkIsNumber(textLebar) || !helper.checkIsNumber(textTinggi))
            {
                MessageBox.Show("Inputan hanya boleh angka!", "Alert");
                return;
            }

            Balok balok = new Balok();
            balok.panjang = int.Parse(textPanjang.Text);
            balok.lebar = int.Parse(textLebar.Text);
            balok.tinggi = int.Parse(textTinggi.Text);

            labelHasil.Text = balok.volume.ToString();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm form = new HomeForm();
            form.Show();
        }
    }
}
