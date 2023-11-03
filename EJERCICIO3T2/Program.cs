using EJERCICIO3T2.Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.menuPrincipal();
            do
            {
                switch (opcion)
                {
                    case 0:
                        opcion = Pantallas.menuPrincipal();
                        break;
                    case 1:
                        opcion = Pantallas.sumar();
                        break;
                    case 2:
                        opcion = Pantallas.restar();
                        break;
                    case 3:
                        opcion = Pantallas.multiplicar();
                        break;
                    case 4:
                        opcion = Pantallas.dividir();
                        break;
                }
            } while (opcion != 5);
        }
    }
}
