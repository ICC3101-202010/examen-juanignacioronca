using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Juan_Roncagliolo
{
    public class Entrenador:Persona
    {
        public int Puntos_de_tactica;
        public int cambios = 0;
        public Entrenador(string nombre, int edad, string nacion, int sueldo,int puntos_de_tactica)
        {
            Nombre = nombre;
            Edad = edad;
            Nacion = nacion;
            Sueldo = sueldo;
            Puntos_de_tactica = puntos_de_tactica;
        }
        public void Cambiar_jugador(Equipo equipo,int jugador)
        {
            Console.WriteLine("El entrenador realiza un cambio de jugadores");
            equipo.Jugadores_en_cancha[jugador] = equipo.Jugadores[cambios + 11];
            cambios += 1;
        }
        public string Informacion()
        {
            string a = Nombre + " |" + Edad + " |" + Nacion + " |" + Sueldo + " |" + Puntos_de_tactica;
            return a;
        }
    }
}
