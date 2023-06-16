using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class MainController : ApiController
    {
        // GET: api/Productos
        public List<Contacto> Get()
        {
            List<Contacto> oList = new List<Contacto>();
            using (TestEntities db = new TestEntities())
            {
                oList = db.Contacto.ToList();
            }
            return oList;
        }

        //POST: api/Contacto
        public void Post([FromBody] Contacto value)
        {
            using (TestEntities db = new TestEntities())
            {
                db.Contacto.Add(value);
                db.SaveChanges();
            }
        }
    }
}