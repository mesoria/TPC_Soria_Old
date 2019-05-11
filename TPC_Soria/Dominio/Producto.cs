using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public float PrecioVenta { get; set; }
        public float PricioCompra { get; set; }
        public Stock Stock { get; set; }
        public Marca Marca { get; set; }
        public DateTime Vencimiento { get; set; }
        public CategoriaProducto Categoria { get; set; }
    }
}
