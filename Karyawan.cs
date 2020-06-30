using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLab9
{
    abstract class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }

        public abstract double Gaji();
    }
}
