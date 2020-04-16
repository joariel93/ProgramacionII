using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio29;


namespace Ejercicio29
{
    class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        public string nombre;

        private Equipo ()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo (short cantidadDeJugadores,string nombre):this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;

        }
        public static bool operator + (Equipo e, Jugador j)
        {
            bool yaEstaba=default;
            bool loAgregue=default;

            foreach (Jugador item in e.jugadores)
            {
                if (j == item)
                {
                    yaEstaba = true;
                    break;
                }
            }
            if (e.cantidadDeJugadores > e.jugadores.Count && !yaEstaba)
            {
                loAgregue = true;
                e.jugadores.Add(j);
            }
            
            
            return loAgregue;
        }

    }
}
