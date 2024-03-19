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
    public partial class KerucutForm : Form
    {
        public KerucutForm()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            labelHasil.Text = "?";
            Helper helper = new Helper();

            if (!helper.checkIsEmpty(textJariJari) || !helper.checkIsEmpty(textTinggi))
            {
                MessageBox.Show("Inputan tidak boleh kosong!", "Alert");
                return;
            }

            if (!helper.checkIsNumber(textJariJari) || !helper.checkIsNumber(textTinggi))
            {
                MessageBox.Show("Inputan hanya boleh angka!", "Alert");
                return;
            }

            Kerucut kerucut = new Kerucut();
            kerucut.jariJari = int.Parse(textJariJari.Text);
            kerucut.tinggi = int.Parse(textTinggi.Text);

            labelHasil.Text = kerucut.volume.ToString();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm form = new HomeForm();
            form.Show();
        }
    }
}
