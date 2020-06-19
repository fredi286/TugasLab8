using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLab8
{
    public abstract class Pekerja
    {
        public string Nama { get; set; }
        public string Nik { get; set; }
        public abstract double Gaji();
    }
}