using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examen_Juan_Roncagliolo
{
    static class Partido
    {
        public static Equipo Equipo_1;
        public static Equipo Equipo_2;
        public static int Tiempo = 45;
        public static int Tiempo_transucrrido = 0;
        public static int Primer_Tiempo = 1;
        public static int Goles_Equipo_1 =0;
        public static int Goles_Equipo_2 =0;
        public static void Jugar(Equipo equipo_1,Equipo equipo_2)
        {
            Equipo_1 = equipo_1;
            Equipo_2 = equipo_2;
            Goles_Equipo_1 = 0;
            Goles_Equipo_2 = 0;
            if (equipo_1.Es_liga == equipo_2.Es_liga)
            {
                Tiempo_transucrrido = 0;
                Console.WriteLine("Comenzo comenzo comenzo!! señoras y señores, el clasico entre "+equipo_1.Nombre+" y "+equipo_2.Nombre+".");
                double fact_lesion = 0.1;
                double fact_gol = 0.15;
                Random random = new Random();
                while (Tiempo_transucrrido <= Tiempo)
                {                    
                    Console.WriteLine(Tiempo_transucrrido+" min. "+equipo_1.Nombre+": "+Goles_Equipo_1+"|" + equipo_2.Nombre + ": "+ Goles_Equipo_2);
                    double random_gol = random.NextDouble();
                    Gol(equipo_1,random.Next(0,11),fact_gol,random_gol);
                    random_gol = random.NextDouble();
                    Gol(equipo_2, random.Next(0, 11), fact_gol, random_gol);
                    double random_lesion = random.NextDouble();
                    Lesionar(equipo_1, random.Next(0, 11), fact_lesion, random_lesion);
                    random_lesion = random.NextDouble();
                    Lesionar(equipo_2, random.Next(0, 11), fact_lesion, random_lesion);
                    Thread.Sleep(1000);
                    Tiempo_transucrrido += 5;
                    fact_lesion += 0.01;
                    fact_gol += 0.01;
                }
                Console.WriteLine("Fin del primer tiempo\n");
                Tiempo_transucrrido = 0;
                Console.WriteLine("\n\n\n");
                Thread.Sleep(1500);
                Console.WriteLine("Comenzamos el segundo tiempo señoras y señores con 2 equipos que lo daran todo en la cancha.");
                while (Tiempo_transucrrido <= Tiempo)
                {
                    Console.WriteLine(Tiempo_transucrrido + " min. " + equipo_1.Nombre + ": "+ Goles_Equipo_1 + "|" + equipo_2.Nombre + ": "+ Goles_Equipo_2);
                    double random_gol = random.NextDouble();
                    Gol(equipo_1, random.Next(0, 11), fact_gol, random_gol);
                    random_gol = random.NextDouble();
                    Gol(equipo_2, random.Next(0, 11), fact_gol, random_gol);
                    double random_lesion = random.NextDouble();
                    Lesionar(equipo_1, random.Next(0, 11), fact_lesion, random_lesion);
                    random_lesion = random.NextDouble();
                    Lesionar(equipo_2, random.Next(0, 11), fact_lesion, random_lesion);
                    Thread.Sleep(1000);
                    Tiempo_transucrrido += 5;
                }
                Console.WriteLine("Fin del partido. El resultado final es:"+equipo_1.Nombre + ": "+ Goles_Equipo_1 + "|" + equipo_2.Nombre + ": "+ Goles_Equipo_2);
                Console.WriteLine("\n\n\n");
            }
            else
            {
                Console.WriteLine("Partido invalido no puede jugar un equipo de pais contra uno de liga, intente nuevamente");
            }
        }
        public static void Lesionar(Equipo equipo,int jugador, double factor_lesion, double random_lesion)
        {
            if (random_lesion<=factor_lesion)
            {
                equipo.Jugadores_en_cancha[jugador].Lesion = true;
                Console.WriteLine("Pero que dura entrada señoras y señores el jugador " + equipo.Jugadores_en_cancha[jugador].Nombre + " tendra que dejar el campo de juego.");
                equipo.Jugadores_en_cancha[jugador].Avisar_lesion(equipo,equipo.Medico,equipo.Entrenador,random_lesion,jugador);
                
            }
            
        }
        public static void Gol(Equipo equipo,int jugador, double factor_gol, double random_gol)
        {
            if (random_gol <= factor_gol)
            {
                if (equipo == Equipo_1)
                {
                    Goles_Equipo_1 += 1;
                }
                else if (equipo == Equipo_2)
                {
                    Goles_Equipo_2 += 1;
                }
                Console.WriteLine("GOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOLLLLLL señoras y señores que golazo de " + equipo.Jugadores_en_cancha[jugador].Nombre + ".\n");
            }
        }

    }
}
