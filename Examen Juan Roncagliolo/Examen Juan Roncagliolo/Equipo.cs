using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Juan_Roncagliolo
{
    public class Equipo
    {
        public string Nombre;
        public string Nacion;
        public bool Es_liga;
        public List<Jugadores> Jugadores = new List<Jugadores>();
        public List<Jugadores> Jugadores_en_cancha = new List<Jugadores>();
        public Medico Medico;
        public Entrenador Entrenador;

        public Equipo(string nombre, string nacion, bool es_liga, List<Jugadores> jugadores, Medico medico, Entrenador entrenador)
        {
            if (es_liga == true)
            {
                nacion = "Liga";
            }
            if (es_liga == false)
            {
                int i = 0;
                foreach (var item in jugadores)
                {
                    if (item.Nacion == nacion)
                    {
                        i++;
                    }
                    else
                    {
                        break;
                    }

                }
                Jugadores=jugadores;
            }
            for (int i = 0; i < 11; i++)
            {
                Jugadores_en_cancha.Add(jugadores[i]);
            }
            Nombre = nombre;
            Nacion = nacion;
            Es_liga = es_liga;
            Medico = medico;
            Entrenador = entrenador;
        }
        public string Informacion()
        {
            string a = Nombre + " |" + Nacion + " |";
            if (Es_liga)
            {
                a += "Liga";
            }
            foreach (var item in Jugadores)
            {
                a+= item.Infomacion();
            }
            a += Medico.Informacion();
            a += Entrenador.Informacion();
            return a;
        }
    }
}
