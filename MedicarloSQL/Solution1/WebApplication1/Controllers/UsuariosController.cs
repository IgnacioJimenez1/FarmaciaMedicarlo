using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class UsuariosController : ApiController
    {
        // GET: api/Usuarios
        public List<Usuarios> Get()
        {
            List<Usuarios> oList = new List<Usuarios>();
            using (TestEntities db = new TestEntities())
            {
                oList = db.Usuarios.ToList();
            }
            return oList;
        }

        // GET: api/Usuarios/id
        public Usuarios Get(int id)
        {
            Usuarios oItem = new Usuarios();
            using (TestEntities db = new TestEntities())
            {
                oItem = db.Usuarios.Find(id);
            }
            return oItem;
        }

        //POST: api/Alumno
        public void Post([FromBody] Usuarios value)
        {
            using (TestEntities db = new TestEntities())
            {
                db.Usuarios.Add(value);
                db.SaveChanges();
            }
        }

        // PUT: api/Usuarios/5
        public void Put(int id, [FromBody] Usuarios value)
        {
            using (TestEntities db = new TestEntities())
            {
                Usuarios oItem = db.Usuarios.Find(id);
                if (oItem != null)
                {
                    oItem.Nombre = value.Nombre;
                    oItem.Apellido = value.Apellido;
                    oItem.Correo = value.Correo;
                    oItem.Direccion = value.Direccion;
                    oItem.Localidad = value.Localidad;
                    oItem.Telefono = value.Telefono;
                    oItem.Contraseña = value.Contraseña;
                    db.Entry(oItem).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Usuario no existente");
                    // Manejar el caso en el que no se encuentre el objeto con el ID dado
                    // Por ejemplo, puedes lanzar una excepción, mostrar un mensaje de error, etc.
                }
            }
        }

        // DELETE: api/Usuarios/5
        public void Delete(int id)
        {
            using (TestEntities db = new TestEntities())
            {
                Usuarios oItem = db.Usuarios.Find(id);
                db.Usuarios.Remove(oItem);
                db.SaveChanges();
            }
        }
    }
}
