using System;

namespace clase_1_Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo!");

            //int numero = 23;

            //const int MAX = 10; //las variables CONSTANTES se definen con el nombre en mayuscula.

            string nombre;

            Console.WriteLine("Ingrese su nombre"); //WRITE escribe el mensaje en la consola. El read deja que el usuario escriba en consola.

            nombre = Console.ReadLine(); //el usuario escribe en la consola. SIEMPRE DEVUELVE UN STRING.

            Console.WriteLine(nombre); //muestro en consola el nombre ingresado.

            string edadString;
            int edad;
            bool resultadoBoolaneo;

            Console.WriteLine("ingrese su edad");

            edadString = Console.ReadLine();

            resultadoBoolaneo = int.TryParse(edadString, out edad); //intenta convertir "edadString" que es un string, en un int y lo guarda en "edad", y si pudo se guarda true o false en la var "resultadoBoolaneo"

            //Console.ReadKey(); para q no se cierre la consola.
        }
    }
}
