using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class actividad4
    {

     public static void Main4(string[] args)
        {
          
            Programador programador = new Programador();

            programador.SetSueldo(213);
            programador.MostrarInfo();


        }


        class Empleado
        {
            public string nombre;
            public string apellido;
            public string telefono;
            public string email;
            public string dni;
            private decimal sueldo;
            public DeptoSistemas departamento = new DeptoSistemas("sistemas", true, false, 12);


            public Empleado()
            {
                nombre = "Miguel";
                apellido = "Diaz";
                telefono = "15-4355-2342";
                email = "migueldiaz@gmail.com";
                dni = "46738934";

            }

            public decimal GetSueldo()
            {
                return sueldo;
            }

            public void SetSueldo(decimal nuevoSueldo)
            {
                sueldo = nuevoSueldo;
            }

        }

        class DeptoSistemas
        {
            public string area;
            public bool tieneTituloRelacionado;
            public bool tienePC;
            public int cantGente;

            public DeptoSistemas(string area, bool tieneTituloRelacionado, bool tienePC, int cantGente)
            {
                this.area = area;
                this.tieneTituloRelacionado = tieneTituloRelacionado;
                this.tienePC = tienePC;
                this.cantGente = cantGente;
            }
        }

        class Programador : Empleado
        {
            public string lenguaje;
            public string categoria;
            public int cantTumbadas;


            public Programador ()
              {

                lenguaje = "Python";
                categoria = "Senior";
                cantTumbadas = 1234;
}

            
            public void MostrarInfo()
            {
                Console.WriteLine($"Info: Nombre: {nombre} {apellido} Tel: {telefono} Email: {email} Sueldo: {GetSueldo()} DNI: {dni} Lenguaje: {lenguaje} Categoria: {categoria}, Cantidad de tumbadas:  {cantTumbadas} Info depto sistemas: Area: {departamento.area}, Cantidad de gente a dispocicision: {departamento.cantGente}, Tiene titulo: {departamento.tieneTituloRelacionado}, Tiene PC: {departamento.tienePC}");
            }
        }
    }
}


/*
 4) Definir la clase Empleado, con nombre, apellido, telefono, email, dni y sueldo.
Definir la clase DptoSistemas (para el Departamento de Sistemas) que posea el área en la
que trabaja de Sistemas, si posee titulo relacionado a su trabajo, si posee una computadora laboral a
su cargo y cantidad de gente a cargo.

Definir la clase Programador donde se almacene en que lenguaje de programación trabaja, si
es senior, semisenior o junior y la cantidad de veces que tumbó producción.

Crear un método mostrar información del empleado en la clase Programador donde muestre
toda la información requerida.
 */