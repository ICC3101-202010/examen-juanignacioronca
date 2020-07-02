using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Juan_Roncagliolo
{
    public class Medico:Persona
    {
        public int Puntos_de_experiencia;

        public Medico(string nombre, int edad, string nacion, int sueldo,int puntos_de_experiencia)
        {
            Nombre = nombre;
            Edad = edad;
            Nacion = nacion;
            Sueldo = sueldo;
            Puntos_de_experiencia = puntos_de_experiencia;
        }
        public void Evaluar(Equipo equipo,double factor,Entrenador entrenador,int jugador)
        {
            if (factor<=0.4)
            {
                Curar();
            }
            else
            {
                entrenador.Cambiar_jugador(equipo,jugador);
            }
        }
        public void Curar()
        {
            Console.WriteLine("El medico del equipo logra curar al jugador y hacer que vuelva a la cancha.");
        }
        public string Informacion()
        {
            string a = Nombre + " |" + Edad + " |" + Nacion + " |" + Sueldo + " |" + Puntos_de_experiencia;
            return a;
        }
    }
}
