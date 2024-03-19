using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunRuang.Controllers
{
    internal class Bola
    {
        private int jariJari;        

        public double volume
        {
            get
            {
                Helper helper = new Helper();
                return (4/3) * Helper._phi * helper.getFactorial(jariJari, 3);
            }
            set
            {
                jariJari = (int) value;
            }
        }
    }
}
