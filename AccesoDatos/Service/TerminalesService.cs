using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.POGO;
namespace AccesoDatos.Service
{
     interface TerminalesService
    {
        Terminales GetAll();
        Terminal GetById(int id);
    }
}
