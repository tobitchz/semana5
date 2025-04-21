using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class actividad7
    {

        public static void Main(string[] args) 
        { 
            Tren tren = new Tren(); 
            Vagon vagon = new Vagon();

            tren.Acelerar();
            tren.Frenar();
            vagon.VagonLleno();

        }

        class Tren
        {
            public int velocidad;

            public Tren()
            {
                velocidad = 0;  
            }

            public void Acelerar() 
            {
                for (int i = 0; i <= 120; i++) 
                {
                    Console.WriteLine($"Velocimetro: {velocidad++} km/h");
                }
            }

            public void Frenar()
            {
                velocidad = 0;
                Console.WriteLine("Se piso el freno!");
                Console.WriteLine($"Velocimetro: {velocidad} km/h");
            }
        }

        class Vagon : Tren 
        {
            public void VagonLleno()
            {
                Console.WriteLine("El vagon esta lleno!");
            }
        }


    }
}

/*
 7) Definir la clase Tren y su hija, Vagón. Se deben crear los métodos vagonLleno, ascelerar(int
velocidad) y frenar.
 */
