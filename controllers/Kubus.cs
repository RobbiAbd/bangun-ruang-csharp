using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunRuang
{
    internal class Kubus
    {
        private int sisi;

        public int volume {  
            get {
                return sisi * 3;
            }
            set {
                sisi = value;
            } 
        }
    }
}
