using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ManipulacionStringEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string primerNombre = "Juan";
            //String segundoNombre = "Perez";
            ////var nombreCompleto = primerNombre + " " + segundoNombre;//concatenación
            ////var nombreCompleto =string.Concat(primerNombre, " ",segundoNombre);//concatenación
            //var nombreCompleto = $"{primerNombre} {segundoNombre}";
            //Console.WriteLine(nombreCompleto);
            //char caracter = nombreCompleto[50];
            
            //Console.WriteLine(caracter);
            //string movieName = "Lord Of The Rings";

            ////Indexes
            //var caracter = movieName[10];
            //Console.WriteLine(caracter);
            ////Length
            //Console.WriteLine(movieName.Length);//Cantidad de caracteres

            ////Ejemplo con las anteriores
            //Console.Write("Ingrese el nro de caracter a obtener:");
            //int indice = int.Parse(Console.ReadLine());
            //if (indice>movieName.Length-1 ||indice<0)
            //{
            //    Console.WriteLine("Indice fuera del rango permitido");
            //}
            //else
            //{
            //    Console.WriteLine(movieName[indice]);
                
            //}
            string movieName = "             Lord of the rings     ";
            Console.WriteLine(movieName.Length);
            //TRIM
            Console.WriteLine(movieName);
            Console.WriteLine(movieName.TrimStart());
            Console.WriteLine(movieName.TrimStart().Length);

            Console.WriteLine(movieName.TrimEnd());
            Console.WriteLine(movieName.TrimEnd().Length);
            Console.WriteLine(movieName.Trim());
            Console.WriteLine(movieName.Trim().Length);

            //IndexOf
            Console.WriteLine(movieName.Trim().IndexOf('x'));//devuelve la posicion del caracter
            Console.WriteLine(movieName.Trim().IndexOf('o'));
            //LastIndexOf
            Console.WriteLine(movieName.Trim().LastIndexOf('o'));
            //Replace
            Console.WriteLine(movieName.Trim().Replace('o','%'));
            //Remove
            Console.WriteLine(movieName.Trim().Remove(0,4));
            //Insert
            movieName = movieName.Trim().Insert(0, "The ");
            //Console.WriteLine(movieName.Trim().Insert(0,"The "));
            Console.WriteLine(movieName);
            //Upper
            Console.WriteLine(movieName.Trim().ToUpper());
            //Lower
            Console.WriteLine(movieName.Trim().ToLower());
            //Substring
            Console.WriteLine(movieName.Substring(0,8));
            //Split
            var palabras = movieName.Split(' ');
            Console.WriteLine(palabras.Length);
            Console.WriteLine(palabras[0]);//The
            Console.WriteLine(palabras[1]);//lord
            Console.WriteLine(palabras[2]);
            Console.WriteLine(palabras[3]);
            Console.WriteLine(palabras[4]);
        }
    }
}
