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

            //Jugadores Chile
            Jugadores Gabriel_Arias = new Jugadores("Gabriel Arias", 32, "Chile", 10000000, 70, 85, true, 1);
            Jugadores Mauricio_Isla = new Jugadores("Mauricio Isla", 32, "Chile", 10000000, 75, 89, false, 4);
            Jugadores Guillermo_Maripan = new Jugadores("Guillermo Maripan ", 26, "Chile", 10000000, 73, 82, false, 3);
            Jugadores Gary_Medel = new Jugadores("Gary Medel", 32, "Chile", 10000000, 70, 90, false, 17);
            Jugadores Gonzalo_Jara = new Jugadores("Gonzalo Jara", 34, "Chile", 10000000, 70, 85, false, 18);
            Jugadores Arturo_Vidal = new Jugadores("Arturo Vidal", 33, "Chile", 10000000, 90, 85, false, 8);
            Jugadores Jean_Beausejour = new Jugadores("Jean Beausejour ", 36, "Chile", 10000000, 70, 85, false, 15);
            Jugadores Charles_Aranguiz = new Jugadores("Charles Aranguiz ", 31, "Chile", 10000000, 87, 85, false, 20);
            Jugadores Alexis_Sanchez = new Jugadores("Alexis Sanchez", 31, "Chile", 10000000, 93, 85, false, 7);
            Jugadores Eduardo_Vargas = new Jugadores("Eduardo Vargas ", 30, "Chile", 10000000, 90, 85, false, 11);
            Jugadores Nicolas_Castillo = new Jugadores("Nicolas Castillo ", 27, "Chile", 10000000, 90, 85, false, 9);
            Jugadores Junion_Fernandes = new Jugadores("Junion Fernandes ", 32, "Chile", 10000000, 87, 85, false, 19);
            Jugadores Pablo_Hernandez = new Jugadores("Pablo Hernandez ", 33, "Chile", 10000000, 80, 85, false, 16);
            Jugadores Erick_Pulgar = new Jugadores("Erick Pulgar", 26, "Chile", 10000000, 70, 85, false, 13);
            Jugadores Jose_Pedro_Fuezalida = new Jugadores("Jose Pedro Fuezalida ", 35, "Chile", 10000000, 86, 85, false, 6);
            Medico Fernando_Yanez = new Medico("Fernando Yanez ", 50, "Chile", 10000000, 80);
            Entrenador Reinaldo_Rueda = new Entrenador("Reinaldo Rueda Arias", 63, "Chile", 10000000, 80);
            //Equipo Chile
            List<Jugadores> temp = new List<Jugadores>();
            temp.Add(Gabriel_Arias);
            temp.Add(Mauricio_Isla);
            temp.Add(Guillermo_Maripan);
            temp.Add(Gary_Medel);
            temp.Add(Gonzalo_Jara);
            temp.Add(Arturo_Vidal);
            temp.Add(Jean_Beausejour);
            temp.Add(Charles_Aranguiz);
            temp.Add(Alexis_Sanchez);
            temp.Add(Eduardo_Vargas);
            temp.Add(Nicolas_Castillo);
            temp.Add(Junion_Fernandes);
            temp.Add(Pablo_Hernandez);
            temp.Add(Erick_Pulgar);
            temp.Add(Jose_Pedro_Fuezalida);
            Lista_Jugadores.Add(Gabriel_Arias);
            Lista_Jugadores.Add(Mauricio_Isla);
            Lista_Jugadores.Add(Guillermo_Maripan);
            Lista_Jugadores.Add(Gary_Medel);
            Lista_Jugadores.Add(Gonzalo_Jara);
            Lista_Jugadores.Add(Arturo_Vidal);
            Lista_Jugadores.Add(Jean_Beausejour);
            Lista_Jugadores.Add(Charles_Aranguiz);
            Lista_Jugadores.Add(Alexis_Sanchez);
            Lista_Jugadores.Add(Eduardo_Vargas);
            Lista_Jugadores.Add(Nicolas_Castillo);
            Lista_Jugadores.Add(Junion_Fernandes);
            Lista_Jugadores.Add(Pablo_Hernandez);
            Lista_Jugadores.Add(Erick_Pulgar);
            Lista_Jugadores.Add(Jose_Pedro_Fuezalida);
            
            Equipo Seleccion_Chilena = new Equipo("Seleccion Chilena", "Chile", false,temp, Fernando_Yanez, Reinaldo_Rueda);
            Equipo Seleccion_Chilena2 = new Equipo("Seleccion Chilena 2", "Chile", false, temp, Fernando_Yanez, Reinaldo_Rueda);
            Lista_Equipos.Add(Seleccion_Chilena);
            Lista_Equipos.Add(Seleccion_Chilena2);

            int a = -1;
            while (a!=0)
            {
                Console.WriteLine("Bienvenido al simulador de partidos\n1.Simular\n2.Ver infomacion\n0.Para salir");
                a = Convert.ToInt32(Console.ReadLine());
                if (a ==1)
                {
                    int a_1 = 1;
                    Console.WriteLine("Seleccione a los 2 equipos.");
                    foreach (var item in Lista_Equipos)
                    {
                        Console.WriteLine(a_1+". "+item.Nombre);
                        a_1++;
                    }
                    int a_2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Equipo 1 seleccionado: " + Lista_Equipos[a_2 - 1].Nombre);
                    int a_3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Equipo 2 seleccionado: " + Lista_Equipos[a_3 - 1].Nombre);
                    if (a_2==a_3)
                    {
                        Console.WriteLine("No puede elegir el mismo equipo, intente nuevamente");
                    }
                    else if (a_2>=0 &&a_2<= Lista_Equipos.Count && a_3 >= 0 && a_3 <= Lista_Equipos.Count &&a_2!=a_3)
                    {
                        Partido.Jugar(Lista_Equipos[a_2 - 1], Lista_Equipos[a_3 - 1]);
                    }
                    
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
