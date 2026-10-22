using System.Collections.Generic;

namespace TiendaApp.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}