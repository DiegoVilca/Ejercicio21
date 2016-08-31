using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespace dolar
using NamespaceDolar;

namespace NamespaceEuro
{
    public class Euro
    {
        public double cantidad;

        //Constructores
        public Euro()
        { 
        }

        public Euro(double cantidad)
            : this()
        {
            this.cantidad = cantidad;
        }

        public static Euro operator + (Euro euro, Dolar dolar )
        {
            return new Euro(euro.cantidad + dolar.cantidad / 1.3642);
        }

        public static Euro operator - (Euro euro, Dolar dolar)
        {
            return new Euro(euro.cantidad - dolar.cantidad / 1.3642);
        }

        public static bool operator == (Euro euro, Dolar dolar)
        {
            if (euro.cantidad == dolar.cantidad / 1.3642)
            return true;
            return false;
        }

        public static bool operator != (Euro euro, Dolar dolar)
        {
            return !(euro.cantidad == dolar.cantidad / 1.3642);
        }

        public static Euro operator ++(Euro euro)
        {

            return new Euro(euro.cantidad++);
        }

        public static Euro operator --(Euro euro)
        {
            return new Euro(euro.cantidad--);
        }


        public static implicit operator Euro (Dolar dolar)
        {
            return new Euro(dolar.cantidad / 1.3642);
        }

        public static implicit operator double(Euro euro)
        {
            return euro.cantidad;

        }

    }
}
