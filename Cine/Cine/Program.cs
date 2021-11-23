using System;
using System.Text;

namespace Cine
{
    public class Program
    {
        
        static void Main(string[] args)
        {
           
            var cartelera1 = new Cartelera();
            var cinePULENTO = new Cine() { cartelera = cartelera1 };
            
            //declarar salas
            var sala1 = new Sala() { tipoSala = "SALA PULENTA 1" };
            var sala2 = new Sala() { tipoSala = "SALA PULENTA 2" };
            var sala3 = new Sala() { tipoSala = "SALA PULENTA XD" };
            var sala4 = new Sala() { tipoSala = "SALA PULENTA PREMIUM" };

            //declarar funciones (usé horario como un int para hacer el quicksort mucho más fácil)
            var piePequeno1 = new Funcion() { horario = 1000, sala = sala3, pelicula = "Pie Pequeño" };
            var piePequeno2 = new Funcion() { horario = 1300, sala = sala3, pelicula = "Pie Pequeño" };
            var piePequeno3 = new Funcion() { horario = 1000, sala = sala1, pelicula = "Pie Pequeño" };
            var piePequeno4 = new Funcion() { horario = 1300, sala = sala1, pelicula = "Pie Pequeño" };

            var elPadrino1 = new Funcion() { horario = 1500, sala = sala3, pelicula = "El Padrino"};
            var elPadrino2 = new Funcion() { horario = 1900, sala = sala3, pelicula = "El Padrino" };
            var elPadrino3 = new Funcion() { horario = 2200, sala = sala3, pelicula = "El Padrino" };
            var elPadrino4 = new Funcion() { horario = 1600, sala = sala1, pelicula = "El Padrino" };
            var elPadrino5 = new Funcion() { horario = 2000, sala = sala1, pelicula = "El Padrino" };
            var elPadrino6 = new Funcion() { horario = 2300, sala = sala1, pelicula = "El Padrino" };

            var laMascara1 = new Funcion() { horario = 1300, sala = sala2, pelicula = "La Mascara" };
            var laMascara2 = new Funcion() { horario = 1600, sala = sala2, pelicula = "La Mascara" };

            var forestGump1 = new Funcion() { horario = 2000, sala = sala2, pelicula = "Forest Gump" };
            var forestGump2 = new Funcion() { horario = 2200, sala = sala2, pelicula = "Forest Gump" };

            var pikachus1 = new Funcion() { horario = 2355, sala = sala4, pelicula = "El pikachus detective" };
            var poluxin69 = new Funcion() { horario = 2350, sala = sala4, pelicula = "MTB en Nevados de Chillán" };

            //agregar funciones a la lista funcion

            cartelera1.funciones.Add(piePequeno1);
            cartelera1.funciones.Add(piePequeno2);
            cartelera1.funciones.Add(piePequeno3);
            cartelera1.funciones.Add(piePequeno4);
            
            cartelera1.funciones.Add(elPadrino1);
            cartelera1.funciones.Add(elPadrino2);
            cartelera1.funciones.Add(elPadrino3);
            cartelera1.funciones.Add(elPadrino4);
            cartelera1.funciones.Add(elPadrino5);
            cartelera1.funciones.Add(elPadrino6);

            cartelera1.funciones.Add(laMascara1);
            cartelera1.funciones.Add(laMascara2);

            cartelera1.funciones.Add(forestGump1);
            cartelera1.funciones.Add(forestGump2);

            cartelera1.funciones.Add(pikachus1);
            cartelera1.funciones.Add(poluxin69);

            //agregar salas a la lista de sala
            cinePULENTO.salas.Add(sala3);
            cinePULENTO.salas.Add(sala1);
            cinePULENTO.salas.Add(sala2);
            cinePULENTO.salas.Add(sala4);
        
            cinePULENTO.OrdenarPorHora();
          
            //lo siento por esto profe, pero es entrete(hay muchos beeps lo siento por eso también...) 
            for (int puntos = 0; puntos <= 3; ++puntos)
            {
                Console.Write("\rCargando funciones por sala{0}", new string('.', puntos));
                System.Threading.Thread.Sleep(500); // 500ms 
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("");
            for (int i = 0; i < cinePULENTO.salas.Count; i++)
            {
                Console.WriteLine("\n"+cinePULENTO.salas[i].tipoSala);
                System.Threading.Thread.Sleep(500);

                for (int j = 0; j < cartelera1.funciones.Count; j++)
                {
                    //conversión de int/string a datetime/string 
                    var h = cartelera1.funciones[j].horario.ToString();
                    DateTime hora = DateTime.ParseExact(h, "HHmm", null);
                    if (cinePULENTO.salas[i].tipoSala == cartelera1.funciones[j].sala.tipoSala)
                    {    
                        
                        Console.WriteLine(hora.ToString("HH:mm") + (" ") + cinePULENTO.cartelera.funciones[j].pelicula);
                        Console.Beep();
                    }

                }

            }

            Console.WriteLine("\nEl trabajo está para un 7,0? [si/no]\n");

            string opcion = Console.ReadLine();

            if (opcion == "si")
            {
                
                Console.WriteLine("");
                Console.WriteLine("ok muchas gracias");
                System.Threading.Thread.Sleep(500);
                Console.OutputEncoding = Encoding.UTF8; //donde la consola usa por defecto utf-16 lo tuve que convertir a utf-8 para mostrar esa cara
                Console.WriteLine("( ͡° ͜ʖ ͡°)");
                System.Threading.Thread.Sleep(2500);
            }

            if (opcion == "no")
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine("        /\v_/\v        _");
                    Console.WriteLine("       /``   \v       / )");
                    Console.WriteLine("       |n n   |__    ( (");
                    Console.WriteLine("      =(Y =.'`   `\v \v \v");
                    Console.WriteLine("       {`'`        \v  ))");
                    Console.WriteLine("       {       /    |/ /");
                    Console.WriteLine("        \\   ,(     / /");
                    Console.WriteLine("        ) ) /-'\v  ,_.'");
                    Console.WriteLine("       (,(,/ ((,,/");
                    Console.WriteLine("\a \n"); //no sabía pero descubrí que el \a activa una alarma de windows

                    Console.Beep(37, 1500); //frecuencia, duración
                }
            }
            
        }
    }
}
