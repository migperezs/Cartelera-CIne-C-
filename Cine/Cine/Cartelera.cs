using System;
using System.Collections.Generic;
using System.Text;

namespace Cine
{
    public class Cartelera 
    {
        
        public List<Funcion> funciones { get; set; }

        public Cartelera()
        {
            funciones = new List<Funcion>(); 
        }
        
    }

}
