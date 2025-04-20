using System;


namespace Ejercicio5

{

    class Actividad2
    {
        public static void Main(String[] args)
        {

            Cuadrado cuadrado = new Cuadrado();
            Triangulo triangulo = new Triangulo();
            Circulo circulo = new Circulo();


            cuadrado.MostrarArea();
            triangulo.MostrarArea();
            circulo.MostrarArea();
        }

        class Figura
        {
            public double _base;
            public double altura;
            public double radio;


            public Figura()
            {
                _base = 23;
                altura = 120;
                radio = 65;
            }

            public virtual void MostrarArea()
            {
                Console.WriteLine("mostrar area");
            }


            
        }

        class Cuadrado : Figura
        {


            public override void MostrarArea() 
            {
                double area = _base * altura;

                Console.WriteLine($"El area del cuadrado es: {area}");
            }
        }

        class Triangulo : Figura
        {

            public override void MostrarArea()
            {

                double area = (_base * altura) / 2;
                Console.WriteLine($"El area del triangulo es: {area}");
            }
        }

        class Circulo : Figura
        {
            public override void MostrarArea()
            {
                double area = Math.Pow(radio,2) * Math.PI;
                Console.WriteLine($"El area del circulo es: {area}");
            }
        }
    }


}


/*
 Se requiere un programa que nos ayude a calcular el área de un Triangulo, de un Cuadrado y de
un Circulo y que éstas clases dependan de la clase Figura, la cual debe tener un método que sea
mostrarArea, donde debe consulte el valor de la variable area y si no es nulo, mostrar por consola
el valor
*/