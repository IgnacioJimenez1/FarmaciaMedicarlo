using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ProductosController : ApiController
    {
        // GET: api/Productos
        public List<Productos> Get()
        {
            List<Productos> oList = new List<Productos>();
            using (TestEntities db = new TestEntities())
            {
                oList = db.Productos.ToList();
            }
            return oList;
        }

        // GET: api/Productos/id
        public Productos Get(int id)
        {
            Productos oItem = new Productos();
            using (TestEntities db = new TestEntities())
            {
                oItem = db.Productos.Find(id);
            }
            return oItem;
        }

        //POST: api/Productos
        public void Post([FromBody] Productos value)
        {
            using (TestEntities db = new TestEntities())
            {
                db.Productos.Add(value);
                db.SaveChanges();
            }
        }

        // PUT: api/Productos/5
        public void Put(int id, [FromBody] Productos value)
        {
            using (TestEntities db = new TestEntities())
            {
                Productos oItem = db.Productos.Find(id);
                if (oItem != null)
                {
                    oItem.nombre = value.nombre;
                    oItem.descripcion = value.descripcion;
                    oItem.precio = value.precio;
                    oItem.stock = value.stock;
                    oItem.imagen = value.imagen;
                    db.Entry(oItem).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Producto no existente");
                    // Manejar el caso en el que no se encuentre el objeto con el ID dado
                    // Por ejemplo, puedes lanzar una excepción, mostrar un mensaje de error, etc.
                }
            }
        }

        // DELETE: api/Productos/5
        public void Delete(int id)
        {
            using (TestEntities db = new TestEntities())
            {
                Productos oItem = db.Productos.Find(id);
                db.Productos.Remove(oItem);
                db.SaveChanges();
            }
        }
    }
}