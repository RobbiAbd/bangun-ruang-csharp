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
    public partial class KubusForm : Form
    {
        public KubusForm()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            labelHasil.Text = "?";
            Helper helper = new Helper();

            if (!helper.checkIsEmpty(textSisi))
            {
                MessageBox.Show("Inputan tidak boleh kosong!", "Alert");
                return;
            }

            if (!helper.checkIsNumber(textSisi))
            {
                MessageBox.Show("Inputan hanya boleh angka!", "Alert");
                return;
            }            

            int hasil, sisi = int.Parse(textSisi.Text);

            Kubus kubus = new Kubus();
            kubus.volume = sisi;

            hasil = kubus.volume;
            labelHasil.Text = hasil.ToString();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm form = new HomeForm();
            form.Show();
        }
    }
}
