using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.POGO;
namespace AccesoDatos.Service
{
    public class TerminalesServiceImpl : TerminalesService
    {
        public Terminales GetAll()
        {
            using (PruebaApiRestEntities db = new PruebaApiRestEntities())
            {
                return new Terminales(db.TERMINALES.ToList());
            }
        }

        public Terminal GetById(int id)
        {
            using (PruebaApiRestEntities db = new PruebaApiRestEntities())
            {
                return new Terminal(db.TERMINALES.Where(x => x.ID_TERMINAL == id).FirstOrDefault());
            }
        }
    }
}
