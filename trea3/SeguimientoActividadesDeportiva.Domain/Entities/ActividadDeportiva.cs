using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoActividadesDeportiva.Domain.Entities
{
    internal class ActividadDeportiva

    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public int DuracionMinutos { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public int CategoriaDeporteId { get; set; }
        public CategoriaDeportiva CategoriaDeportiva { get; set; } = null!;
    }
}
