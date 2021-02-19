using System;

namespace Practica_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre,apellido;
            double notaUno = 0;
            double notaDos = 0;
            double notaTres = 0;
            double promedio = 0;

            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la primera nota");
            notaUno = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota");
            notaDos = double.Parse(Console.ReadLine());
            Console.WriteLine("Imgrese la tercera nota");
            notaTres = double.Parse(Console.ReadLine());

            promedio = (notaUno + notaDos + notaTres) / 3;

            if (promedio >= 3)
                Console.WriteLine("El estudiante " + nombre +" "+ apellido + " Aprobo la materia, su promedio es de " + promedio);
            else
                Console.WriteLine("El estudiante " + nombre +" "+ apellido + " reprobo la materia, su promedio es de "+ promedio);
        }
    }
}
