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
        public const double _phi = 3.14;

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

        public int getFactorial(int number, int factor)
        {
            int result = number;
            if (factor > 0)
            {
                for (int i = 1; i < factor; i++)
                {
                    result *= number;
                }
            }

            return result;
        }
    }
}
