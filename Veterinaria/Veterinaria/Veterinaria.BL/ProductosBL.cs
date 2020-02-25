using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.BL
{
    public class ProductosBL
    {
        Contexto _contexto;

        public List<Productos> ListadeProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListadeProductos = new List<Productos>();

        }
        public List<Productos> ObtenerProductos()
        {
                  
             ListadeProductos = _contexto.Productos.ToList();
            return ListadeProductos;
        }

        public void GuardarProductos(Productos productos)
        {
            if(productos.Id == 0)
            {
                _contexto.Productos.Add(productos);
            } else
            {
                var productosExistente = _contexto.Productos.Find(productos.Id);
                productosExistente.Descripcion = productos.Descripcion;
                productosExistente.Precio = productos.Precio;
            }
            
            _contexto.SaveChanges();
        }

        public Productos ObtenerProductos(int id)
        {
            var productos = _contexto.Productos.Find(id);

            return productos;
        }

        public void EliminarProductos(int id)
        {
            var productos = _contexto.Productos.Find(id);

            _contexto.Productos.Remove(productos);
            _contexto.SaveChanges();
        }
    }
}
