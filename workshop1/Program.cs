using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("n:");
            int valor = 0;
            string entrada = Console.ReadLine();
            List<int> resultado = new List<int>();
            if(int.TryParse(entrada,out valor))
             resultado=Collatz(valor);
            if (resultado.Count > 0)
            {
                foreach(var item in resultado)
                {
                    Console.Write(item + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("**Histograma**");
            Console.WriteLine("Ingrese varios valores termine con cero:");
            Histograma();
            Console.ReadKey();
        }

        /// <summary>
        /// Autor:Fernando Tziu Gomez
        /// La secuencia de Collatz de un número entero se construye de la siguiente forma:
        //•	si el número es par, se divide por dos;
        //•	si es impar, se multiplica tres y se le suma uno;
        //•	la sucesión termina al llegar a uno.

        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static List<int> Collatz(int numero)
        {
            List<int> resultado = new List<int>();
            if (numero>0 && numero<258258)
            {
                resultado.Add(numero);
                do
                {
                    if (numero % 2 == 0)
                    {
                        numero = numero / 2;
                    }
                    else
                        numero = (numero * 3) + 1;
                    resultado.Add(numero);

                } while (numero>1);
            }
            
            return resultado;
        }

        /// <summary>
        /// Escriba un programa de consola que pida al usuario que ingrese varios 
        /// valores enteros, que pueden ser positivos o negativos. Cuando se ingrese un cero,
        /// el programa debe terminar y mostrar un gráfico de cuántos valores positivos y 
        /// negativos fueron ingresados
        /// </summary>
        public static void Histograma()
        {
            int entrada;
            
            StringBuilder pos = new StringBuilder();
            StringBuilder neg = new StringBuilder();
           
            do
            {
                entrada = int.Parse(Console.ReadLine());
                if (entrada >= 0) pos.Append("*");
                else
                    neg.Append("*");
            } while (entrada != 0);
            
            Console.WriteLine("Positivos: " + pos);
            Console.WriteLine("Negativos: " + neg);
            Console.ReadKey();
        }
    }
}
