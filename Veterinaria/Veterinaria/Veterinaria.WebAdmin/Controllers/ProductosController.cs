using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Veterinaria.BL;

namespace Veterinaria.WebAdmin.Controllers
{
    public class ProductosController : Controller
    {
        ProductosBL _productosBL;

        public ProductosController()
        {
            _productosBL = new ProductosBL();
        }

        // GET: Productos
        public ActionResult Index()
        {
            var listadeproductos = _productosBL.ObtenerProductos();

            return View(listadeproductos);
        }

    
        public ActionResult Crear()
        {
            var nuevoProducto = new Productos();

            return View(nuevoProducto);
        }

        [HttpPost]
        public ActionResult Crear(Productos productos)
        {
            _productosBL.GuardarProductos(productos);

            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            var productos = _productosBL.ObtenerProductos(id);

            return View(productos);
        }

        [HttpPost]
        public ActionResult Editar(Productos productos)
        {
            _productosBL.GuardarProductos(productos);

            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int id)
        {
            var producto = _productosBL.ObtenerProductos(id);

            return View(producto);
        }

        public ActionResult Eliminar(int id)
        {
            var producto = _productosBL.ObtenerProductos(id);

            return View(producto);
        }

        [HttpPost]
        public ActionResult Eliminar(Productos productos)
        {
            _productosBL.EliminarProductos(productos.Id);
            return RedirectToAction("Index");
        }
    }
}