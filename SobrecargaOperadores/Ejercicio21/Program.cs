using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespaces
using NamespaceDolar;
using NamespaceEuro;

namespace NamespaceProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dolar unDolar = new Dolar(20);
            Dolar resultadoDolar;
            Euro unEuro = new Euro(10);
            Euro resultadoEuro;
            double unDouble;


            //////////////////////////
            ///SOBRECARGAS CLASE DOLAR
            Console.Write("\n\n--------------------------------");
            Console.WriteLine("\nSOBRECARGAS CLASE DOLAR");
            Console.Write("--------------------------------");

            Console.WriteLine("\nValor Dolar: "+unDolar.cantidad);
            Console.WriteLine("\nValor Euro: "+unEuro.cantidad);

            //Suma Dolar

            resultadoDolar = unDolar + unEuro;
            Console.WriteLine("\nSuma dolar: {0}", resultadoDolar.cantidad);

            //Resta Dolar

            resultadoDolar = unDolar - unEuro;
            Console.WriteLine("\nResta dolar: {0}", resultadoDolar.cantidad);

            //Comparacion Dolar

            if (unDolar == unEuro)
            
                Console.WriteLine("\nComparacion dolar: Las cantidades son iguales");
            else
                Console.WriteLine("\nComparacion dolar: Las cantidades no son iguales");
            

            //Incremento dolar

            resultadoDolar = unDolar++;
            Console.WriteLine("\nValor Dolar: {0}\n\nIncremento Dolar: {1}", unDolar.cantidad, resultadoDolar.cantidad);

            //Decremento dolar

            resultadoDolar = unDolar--;
            Console.WriteLine("\nValor dolar: {0}\n\nDecremento Dolar: {1}", unDolar.cantidad, resultadoDolar.cantidad);
            
            //Conversion euro a dolar

            resultadoDolar = unEuro;

            Console.WriteLine("\nConversion euro a dolar: "+ resultadoDolar.cantidad);


            //Conversion dolar a double

            unDouble = unDolar;

            Console.WriteLine("\nConversion dolar a double: " + unDouble);


            ///////////////////////////
            ///SOBRECARGAS CLASE EURO
            Console.Write("\n\n--------------------------------");
            Console.WriteLine("\nSOBRECARGAS CLASE EURO");
            Console.Write("--------------------------------");


            Console.WriteLine("\nValor Dolar: " + unDolar.cantidad);
            Console.WriteLine("\nValor Euro: " + unEuro.cantidad);


            //Suma euro

            resultadoEuro = unEuro + unDolar;
            Console.WriteLine("\nSuma euro: "+ resultadoEuro.cantidad);

            //Resta euro

            resultadoEuro = unEuro - unDolar;
            Console.WriteLine("\nResta euro : "+ resultadoEuro.cantidad);

            //Comparacion euro

            if (unEuro == unDolar)
                Console.WriteLine("\nComparacion euro: Las cantidades son iguales");
            else
               Console.WriteLine("\nComparacion euro: Las cantidades no son iguales");

            //Incremento euro

            resultadoEuro = unEuro++;

            Console.WriteLine("\nIncremento Euro: "+resultadoEuro.cantidad);

            //Decremento euro

            resultadoEuro = unEuro--;

            Console.WriteLine("\nDecremento Euro: "+ resultadoEuro.cantidad);


            //Conversion dolar a euro

            resultadoEuro = unDolar;

            Console.WriteLine("\nConversion dolar a euro: "+resultadoEuro.cantidad);

            //Conversion euro a double

            unDouble = unEuro;

            Console.WriteLine("\nConversion euro a double: "+ unDouble);

            Console.ReadKey();


        }
    }
}
