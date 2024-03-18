using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BangunRuang
{
    internal class Helper
    {
        public bool checkIsEmpty(System.Windows.Forms.TextBox textBox)
        {
            bool isEmpty = textBox.Text.Length < 1;
            return !isEmpty;
        }

        public bool checkIsNumber(System.Windows.Forms.TextBox textBox)
        {
            int value;
            bool isConverted = Int32.TryParse(textBox.Text.Trim(), out value);
            return isConverted;
        }
    }
}
