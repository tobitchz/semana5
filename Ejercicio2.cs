using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Actividad3
    {

        public static void Main(String[] args)
        {
            CuentaMayor cuentaMayor = new CuentaMayor(10003,"tobias", 1200, "activo", 20);
            cuentaMayor.MostrarInfo();
            cuentaMayor.IngresarMonto(200);
            cuentaMayor.MostrarInfo();
            cuentaMayor.Retirar(150);
            cuentaMayor.MostrarInfo();
            cuentaMayor.VerificarMayorEdad();

        }

        class Cuenta
        {
            public int nro_cuenta;
            public string nombre;
            private decimal saldo;
            public string estado;
            public int edad;


            public Cuenta(int nro_cuenta, string nombre, decimal saldo, string estado, int edad)
            {
                this.nro_cuenta = nro_cuenta;
                this.nombre = nombre;
                this.saldo = saldo;
                this.estado = estado;
                this.edad = edad;

            }


            public void IngresarMonto(int MontoASumar)
            {
                saldo += MontoASumar;
            }

            public void Retirar(int MontoARestar)
            {
                if (MontoARestar > saldo)
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
                else
                {
                    saldo -= MontoARestar;
                }
            }

            public void MostrarInfo() 
            {
                Console.WriteLine($" Numero de cuenta: {nro_cuenta}, Nombre: {nombre}, Saldo ${saldo }, Estado: {estado}");
            }

     
        }

        class CuentaMenor : Cuenta
        {
            public CuentaMenor(int nro_cuenta, string nombre, decimal saldo, string estado, int edad) : base(nro_cuenta,  nombre,  saldo,  estado, edad) { }

        }

        class CuentaEstudiante : Cuenta 
        {
            public CuentaEstudiante(int nro_cuenta, string nombre, decimal saldo, string estado, int edad) : base(nro_cuenta, nombre, saldo, estado, edad) { }
        }

        class CuentaMayor : Cuenta
        {
            public CuentaMayor(int nro_cuenta, string nombre, decimal saldo, string estado, int edad) : base(nro_cuenta, nombre, saldo, estado, edad) { }


            public void VerificarMayorEdad()
            {
                if (edad >= 18)
                {
                    Console.WriteLine("Es mayor de edad.");
                }
                else
                {
                    Console.WriteLine("No es mayor de edad.");
                }
            }

        }


    }
}
/*
 * 
 3) Se requiere que se defina la clase Cuenta con métodos que permitan ingresarMonto(int
montoASumar), retirarMonto(int montoARestar)

mostrar información de la cuenta

(nro_cuenta, nombre, saldo, estado_cuenta) 

de la cuenta y definir las clases CuentaMayor,

CuentaMenor y CuentaEstudiante que puedan ejecutar estos métodos.
En el caso de CuentaMayor, crear un método que consulte si la persona es mayor de 18 años.

 
 */