using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVJ.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Mortal Kombat 9";
            producto1.Disponible = "si";

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Fifa 2020";
            producto2.Disponible = "si";

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Resident Evil";
            producto3.Disponible = "si";

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);

            return listadeProductos;
        }
    }
}
