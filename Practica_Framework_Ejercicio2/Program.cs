using System;

namespace Practica_Framework_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre, apellido;
            int edad;
            int pulsaciones = 0;
            char sexo;

            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el sexo");
            Console.WriteLine("M -> masculino y F -> femenino");
            sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad");
            edad = int.Parse(Console.ReadLine());
           
            if (sexo.Equals('M'))
                pulsaciones = (210 - edad) / 10;
            else if (sexo.Equals('F'))
                pulsaciones = (220 - edad) / 10;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("El nombre es: " + nombre);
            Console.WriteLine("El apellido es: "+apellido);
            Console.WriteLine("El sexo es:" + sexo);
            Console.WriteLine("La edad es de: " + edad);
            Console.WriteLine("La pulsacion por 10 segundo es de " + pulsaciones);
            Console.WriteLine("------------------------------------");
        }
    }
}
