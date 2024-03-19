using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunRuang.Controllers
{
    internal class Kerucut
    {
        public int jariJari, tinggi;

        public double volume
        {
            get
            {
                return 0.33 * Helper._phi * jariJari * jariJari * tinggi;
            }
        }
    }
}
