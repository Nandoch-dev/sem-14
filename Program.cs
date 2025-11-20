using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////CADENA DE CARACTERES///
            /////////////EJERCICIO 2////////////
            char[] a1 = { 'a', 'b', 'c' };//se crea array con elementos fijos y el tamaño se determina automaticamente
            char[] a2 = new char[] { 'a', 'b', 'c' };//se crea array con elemntos fijos igual que en a1 
            char[] a3 = new char[3];// se cre un array indicando el tamaño
            //se da valores 1 por 1 a cada indice del array
            a3[0] = 'a';
            a3[1] = 'b';
            a3[2] = 'c';
            //Utilizamos el Writeline para mostrar en consola la longitud de cada array 
            Console.WriteLine("Tamaño a1[]: {0}", a1.Length);
            Console.WriteLine("Tamaño a2[]: {0}", a2.Length);
            Console.WriteLine("Tamaño a3[]: {0}", a3.Length);
            Console.ReadKey();

            





        }
    }
}
