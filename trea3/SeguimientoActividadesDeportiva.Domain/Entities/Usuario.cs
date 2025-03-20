using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoActividadesDeportiva.Domain.Entities
{
    internal class Usuario
    { 
        public int Id { get; set; }
        public string nombre { get; set; }
        public string Correo { get; set; }
        public int Edad { get; set; }

        public List<ActividadDeportiva> Actividades { get; set; } = new();
    }
}
