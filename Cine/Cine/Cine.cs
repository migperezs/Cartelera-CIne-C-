using System;
using System.Collections.Generic;
using System.Text;

namespace Cine
{
    public class Cine
    {

        public Cartelera cartelera { get; set; }

        public List<Sala> salas { get; set; }

        public Cine()
        {
            salas = new List<Sala>();
        }
            
        public List<Funcion> OrdenarPorHora()
        {
            //acá usé el quicksort, pero para evitarme problemas lo utilicé con la hora
            //en formato int, para después dejarlo con un formato de hora 
            for (int i = 0; i < cartelera.funciones.Count - 1; i++)
            {
                var pivot = new Funcion();
                if (cartelera.funciones[i].horario > cartelera.funciones[i + 1].horario)
                {
                    pivot = cartelera.funciones[i + 1];
                    cartelera.funciones[i + 1] = cartelera.funciones[i];
                    cartelera.funciones[i] = pivot;
                    i = -1;
                }
            }
            return cartelera.funciones;
        }
    }
}
