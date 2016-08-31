using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespace euro
using NamespaceEuro;

namespace NamespaceDolar
{
    public class Dolar
    {
        public double cantidad;

        //Constructores
        public Dolar()
        { 
        }

        public Dolar(double cantidad)
            : this()
        {
            this.cantidad = cantidad;
        }

        public static Dolar operator + (Dolar dolar, Euro euro)
        {
            return new Dolar(dolar.cantidad + euro.cantidad * 1.3642);
        }

        public static Dolar operator - (Dolar dolar, Euro euro)
        {
            return new Dolar(dolar.cantidad - euro.cantidad * 1.3642);
        }

        public static bool operator == (Dolar dolar, Euro euro)
        {
            if (dolar.cantidad == euro.cantidad * 1.3642)
                return true;
            return false;
        }

        public static bool operator != (Dolar dolar, Euro euro)
        {
            return!(dolar.cantidad == euro.cantidad * 1.3642 );
        }

        public static Dolar operator ++(Dolar dolar)
        {
            return new Dolar(dolar.cantidad++);
        }

        public static Dolar operator --(Dolar dolar)
        {
            return new Dolar(dolar.cantidad--);
        }

        public static implicit operator Dolar(Euro euro)
        {
            return new Dolar(euro.cantidad * 1.3642);
        }

        public static implicit operator double(Dolar dolar)
        {
            return dolar.cantidad;
        }
    }
}
