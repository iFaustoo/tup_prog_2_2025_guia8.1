using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    public class Cuenta : IComparable
    {

        public string Nombre { get; set; }
        public int DNI { get; set; }
        public double Importe { get; set; }

        public Cuenta(string nombre, int dni, double importe)
        {
            this.Nombre = nombre;
            this.DNI = dni;
            this.Importe = importe;
        }

        public override string ToString()
        {
            return $"{Nombre} - {DNI} - ${Importe}";
        }

        public int CompareTo(object otherObject)
        {
            Cuenta other = otherObject as Cuenta;
            if (other != null)
            {
                return this.DNI.CompareTo(other.DNI);
            }
            return -1;
        }

    }
}
