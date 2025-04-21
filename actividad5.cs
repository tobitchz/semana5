using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class actividad5
    {

        public static void Main(string[] args)
        {
            Ambiente desarrollo = new Ambiente("linux",4, "postgresql", "openjdk");
            Ambiente testing = new Ambiente("Windows Server 2019", 8, "SQL Server", "app");
            Ambiente preproducciom = new Ambiente("Ubuntu Server 22.04 LTS", 16, "PostgreSQL", "aplicacion");
            Ambiente produccion = new Ambiente("CentOS 7", 32, "MySQL", "app");

            
            desarrollo.VerificarDespliegue();
            testing.VerificarDespliegue();
            preproducciom.VerificarDespliegue();
            produccion.VerificarDespliegue();

        }

        class Ambiente
        {
            public string sistema_operativo;
            public int ram;
            public string base_datos;
            public string app;

            public Ambiente(string sistema_operativo, int ram, string base_datos, string app)
            {
                this.app = app;
                this.ram = ram;
                this.base_datos = base_datos;
                this.sistema_operativo = sistema_operativo;
            }

            public void VerificarDespliegue()
            {
                if (sistema_operativo.Equals("linux") && ram == 4 && base_datos.Equals("postgresql") && app.Equals("openjdk"))
                {
                    Console.WriteLine("El despliegue se puede realizar!");
                }
                else
                {
                    Console.WriteLine("No es posible realizar el despliegue :(.");
                }
            }



        }
    }
}


/*
 5) Definir la clase Ambiente y generar los objetos: “Desarrollo”, “Testing”, “Preproduccion” y
“Produccion” que posea un método que sea verificarDespliegue y comprobar que la información
del Ambiente sea igual a: “sistema_operativo: linux, ram:4, base_datos: postgresql, app: openjdk”,
si es correcto mostrar por pantalla que el despliegue se puede realizar, de lo contrario, mostrar que
no será posible realizar el despliegue.
 
 */