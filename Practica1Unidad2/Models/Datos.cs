using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1Unidad2.Models
{
    public class Datos
    {
        public int n1 { get; set; }
        public int n2 { get; set; }
        public int Resultado()
        {
            return n1 + n2;
        }
    }
}
