using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class ejercicio6
    {
        public static void Main(string[] args)
        {
            Persona persona1 = new Persona(int.Parse(Console.ReadLine()));
            Persona persona2 = new Persona(int.Parse(Console.ReadLine()));

            persona1.CompararEdad(persona1.edad, persona2.edad);
        }



        class Persona 
        {
            public int edad;

            public Persona(int edad)
            { 
                this.edad = edad; 
            }
            

            public void CompararEdad(int edad1, int edad2)
            {
                Console.WriteLine(edad1 > edad2 ? $"{edad1} es mayor que {edad2}" : $"{edad2} es mayor que {edad1}");

            }
        }


    }
}

/*
 6) Crear la clase Persona, con un método que compare la edad de una persona con otra.
(Se deben crear dos objetos de la clase persona, y ejecutar el método compararEdad en persona2,
pasando como parámetro la edad de persona1).
*/