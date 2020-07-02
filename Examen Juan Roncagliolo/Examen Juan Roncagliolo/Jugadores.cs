using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Juan_Roncagliolo
{
    public class Jugadores : Persona
    {
        public int Puntos_de_ataque;
        public int Puntos_de_defensa;
        public bool Es_arquero;
        public int Numero_de_camiseta;
        public bool Lesion;

        public Jugadores(string nombre, int edad, string nacion, int sueldo, int puntos_de_ataque, int puntos_de_defensa, bool es_arquero, int numero_de_camiseta)
        {
            Nombre = nombre;
            Edad = edad;
            Nacion = nacion;
            Sueldo = sueldo;
            Puntos_de_ataque = puntos_de_ataque;
            Puntos_de_defensa = puntos_de_defensa;
            Es_arquero = es_arquero;
            Numero_de_camiseta = numero_de_camiseta;
        }
        public void Avisar_lecion(Equipo equipo, Medico medico,Entrenador entrenador,double factor,int jugador)
        {
            if (Lesion ==true)
            {
                medico.Evaluar(equipo,factor, entrenador,jugador);
            } 
        }
        public string Infomacion()
        {
            string a = Nombre + " |" + Edad + " |" + Nacion + " |" + Sueldo + " |" + Puntos_de_ataque + " |" + Puntos_de_ataque + " |"; 
            if (Es_arquero)
            { 
                a+="Arquero"; 
            }
            a+= " |" +Numero_de_camiseta+"\n";
            return a;
        }
    }
}
