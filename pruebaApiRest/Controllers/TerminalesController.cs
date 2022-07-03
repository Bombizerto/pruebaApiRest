using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using AccesoDatos;
using System.Data.Entity;
namespace pruebaApiRest.Controllers
{
    public class TerminalesController : ApiController
    {
        private PruebaApiRestEntities context = new PruebaApiRestEntities();
        [HttpGet]
        public IEnumerable<TERMINALES> Get()
        {
            using(PruebaApiRestEntities db=new PruebaApiRestEntities())
            {
                return db.TERMINALES.ToList(); ;
            }
        }
        [HttpGet]
        public TERMINALES Get(int id)
        {
            using(PruebaApiRestEntities db=new PruebaApiRestEntities())
            {
                return db.TERMINALES.Where(x => x.ID_TERMINAL == id).FirstOrDefault();
            }
        }

    }
}
