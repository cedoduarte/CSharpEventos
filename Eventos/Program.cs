using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            var juan = new Persona();
            juan.PelotaPateada += new EventHandler(PelotaPateada);
            juan.PateaPelota();
            Console.Read();
        }

        public static void PelotaPateada(object sender, EventArgs e)
        {
            Console.WriteLine("La pelota ha sido pateada");
        }
    }
}
