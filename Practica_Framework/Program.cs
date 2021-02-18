using System;

namespace Practica_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre,apellido;
            double nota1;
            double nota2;
            double nota3;
            double promedio = 0;

            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la primera nota");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Imgrese la tercera nota");
            nota3 = double.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio >= 3)
                Console.WriteLine("El estudiante " + nombre +" "+ apellido + " Aprobo la materia, su promedio es de " + promedio);
            else
                Console.WriteLine("El estudiante " + nombre +" "+ apellido + " reprobo la materia, su promedio es de "+ promedio);
        }
    }
}
