using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunRuang.Controllers
{
    internal class Tabung
    {
        public int jariJari, tinggi;

        public double volume
        {
            get
            {
                return Helper._phi * jariJari * jariJari * tinggi;
            }
        }
    }
}
