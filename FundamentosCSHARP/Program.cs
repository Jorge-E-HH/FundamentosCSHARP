using System;

namespace FundamentosCSHARP
{

    class Program
    {
        static void Main(string[] args)
        {
            var persona =
                new { nombre = "Jorge", apellido = "Hernández", edad = "26"};
            Console.WriteLine(persona.edad);
        }
    }

}
