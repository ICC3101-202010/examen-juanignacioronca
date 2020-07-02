using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Juan_Roncagliolo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jugadores> Lista_Jugadores = new List<Jugadores>();
            List<Equipo> Lista_Equipos = new List<Equipo>();





            
            int a = -1;
            while (a!=0)
            {
                Console.WriteLine("Bienvenido al simulador de partidos\n1.Simular\n2.Ver infomacion\n0.Para salir");
                a = Convert.ToInt32(Console.ReadLine());
                if (a ==1)
                {
                    int a_1 = 1;
                    foreach (var item in Lista_Equipos)
                    {
                        Console.WriteLine(a_1+". "+item.Nombre);
                    }
                    int a_2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Equipo Seleccionado: " + Lista_Equipos[a_2 - 1]);
                    int a_3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Equipo Seleccionado: " + Lista_Equipos[a_3 - 1]);
                    Partido.Jugar(Lista_Equipos[a_2 - 1], Lista_Equipos[a_3 - 1]);
                }
                else if (a==2)
                {
                    foreach (var item in Lista_Equipos)
                    {
                        Console.WriteLine(item.Informacion());
                    }

                }
                else if (a==0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opcion invalida, intente nuevamente");
                }
            }

        }
    }
}
