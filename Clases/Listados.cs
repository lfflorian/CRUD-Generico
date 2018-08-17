using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Listados
    {
        List<Producto> Productos;
        List<Vendedor> Vendedores;

        public Listados()
        {
            Productos = new List<Producto>();
            Vendedores = new List<Vendedor>();

            Productos.Add(new Producto { Id = 0, Nombre = "Producto 1", Precio = 15.50M });
            Productos.Add(new Producto { Id = 1, Nombre = "Producto 2", Precio = 4.40M });
            Productos.Add(new Producto { Id = 2, Nombre = "Producto 3", Precio = 12.00M });
            
            Vendedores.Add(new Vendedor { Id = 0, Nombre = "Vendedor 1", Apellido = "Ramirez" });
            Vendedores.Add(new Vendedor { Id = 0, Nombre = "Vendedor 2", Apellido = "Godinez" });
            Vendedores.Add(new Vendedor { Id = 0, Nombre = "Vendedor 3", Apellido = "Gonzalez" });
        }

        public List<Producto> GetProductos()
        {
            return Productos;
        }

        public List<Vendedor> GetVendedores()
        {
            return Vendedores;
        }
    }
}
