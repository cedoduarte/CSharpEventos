using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public class Persona
    {
        public void PateaPelota()
        {
            PelotaPateada(this, null);
        }

        public event EventHandler PelotaPateada;
    }
}
