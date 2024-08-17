using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase1708.Clase
{
    internal class Tarea
    {
        public Tarea()
        {
        }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public readonly DateTime fechaCreacion;

        public Tarea(string nombre, string estado)
        {
            Nombre = nombre;
            Estado = estado;
            fechaCreacion = DateTime.Now; 
        }
    }
}


        
    

