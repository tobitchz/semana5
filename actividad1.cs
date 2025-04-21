using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class actividad1
    {
        public static void Main(string[] args) 
        {

            Bebida bebida = new Bebida();
            Alimento alimento = new Alimento();

            bebida.Vender();
            bebida.Vender();
            alimento.Vender();
            alimento.Vender();
            alimento.Vender();
            alimento.Vender();

        }

        class Producto
        {
            public int stockBebida;
            public int stockAlimento;

            public Producto()
            {
                stockBebida = 200;
                stockAlimento = 500;
            }

            public virtual void Vender()
            {
                stockBebida--;
                Console.WriteLine("Un alimento se ha vendido");

            }
        }

        class Bebida : Producto
        {

            public override void Vender()
            {
                stockBebida--;
                Console.WriteLine($"Se vendio una bebida {stockBebida}");
            }

        }

        class Alimento : Producto
        {
            public override void Vender()
            {
                stockAlimento--;
                Console.WriteLine($"Se vendio una bebida {stockAlimento}");

            }

        }


    }
}
/*
 1) El supermercado “Eureka” posee un problema al vender productos que no se descuenta del stock
existente.
Se requiere realizar el modelado de las clases del stock de un supermercado, donde se detalle la
clase Producto con sus dos clases hijas: Bebida y Alimento, que posean un método que haga
referencia a la venta de un producto y descuente la cantidad vendida del stock existente.
*/