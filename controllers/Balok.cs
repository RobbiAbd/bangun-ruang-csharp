using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunRuang.controllers
{
    internal class Balok
    {
        public int panjang, lebar, tinggi;

        public int volume
        {
            get
            {
                return panjang * lebar * tinggi;
            }
        }
    }
}
