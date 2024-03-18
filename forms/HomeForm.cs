using BangunRuang.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BangunRuang
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnKubus_Click(object sender, EventArgs e)
        {
            this.Hide();
            KubusForm form = new KubusForm();            
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBalok_Click(object sender, EventArgs e)
        {
            this.Hide();
            BalokForm form = new BalokForm();
            form.Show();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
