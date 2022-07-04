using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using AccesoDatos;
using AccesoDatos.POGO;
using AccesoDatos.Service;
using System.Data.Entity;
using System.Runtime.Caching;

namespace pruebaApiRest.Controllers
{
    public class TerminalesController : ApiController
    {
        private PruebaApiRestEntities context = new PruebaApiRestEntities();
        private TerminalesServiceImpl terminalImpl=new TerminalesServiceImpl();
        [HttpGet]
        public Terminales Get()
        {
            using(PruebaApiRestEntities db=new PruebaApiRestEntities())
            {
                var cache = MemoryCache.Default;
                Terminales terminales;
                if (cache.Get("Terminales") == null)
                {
                    var cachePolicty = new CacheItemPolicy();
                    cachePolicty.AbsoluteExpiration = DateTime.Now.AddSeconds(60);
                    terminales = terminalImpl.GetAll(); 
                    cache.Add("Terminales", terminales, cachePolicty);
                }
                else
                {
                    terminales =(Terminales)cache.Get("Terminales");
                }
                  
                return terminales; 
            }
        }
        [HttpGet]
        public Terminal Get(int id)
        {
            using(PruebaApiRestEntities db=new PruebaApiRestEntities())
            {
                var cache = MemoryCache.Default;
                Terminal terminal;
                Terminales terminales = new Terminales();
                var cachePolicty = new CacheItemPolicy();
                cachePolicty.AbsoluteExpiration = DateTime.Now.AddSeconds(60);
                if (cache.Get("BusquedaTerminal") != null)
                {
                   terminales= (Terminales)cache.Get("BusquedaTerminal");
                   terminal = terminales.vTerminales.Where(x => x.vId_terminal == id).FirstOrDefault();
                    if (terminal == null)
                    {
                        terminal = new Terminal(db.TERMINALES.Where(x => x.ID_TERMINAL == id).FirstOrDefault());
                        terminales.vTerminales.Add(terminal);
                        cache.Remove("BusquedaTerminal");
                        cache.Add("BusquedaTerminal", terminales, cachePolicty);
                    }
                }
                else
                {
                    
                    terminal = terminalImpl.GetById(id);
                    terminales.vTerminales.Add(terminal);
                    cache.Add("BusquedaTerminal", terminales, cachePolicty);
                }
                return terminal;
            }
        }

    }
}
