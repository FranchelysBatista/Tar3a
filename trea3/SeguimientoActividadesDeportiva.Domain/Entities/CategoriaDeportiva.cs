using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoActividadesDeportiva.Domain.Entities
{
    internal class CategoriaDeportiva
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;

        public List<ActividadDeportiva> Actividades { get; set; } = new();
    }
}
