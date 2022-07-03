using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.POGO
{
   public class Fabricante
    {
        private int _id_fab;
        public int vId_fab
        {
            get { return _id_fab; }
            set { _id_fab = value; }
        }
        private String _fab_nombre;
        public String vFab_nombre
        {
            get { return _fab_nombre; }
            set { _fab_nombre = value; }
        }
        private String _fab_desc;
        public String vFab_desc
        {
            get { return _fab_desc; }
            set { _fab_desc = value; }
        }

        public Fabricante(FABRICANTES fabricante)
        {
            vId_fab =Convert.ToInt32(fabricante.ID_FAB);
            vFab_nombre = fabricante.FAB_NAME;
            vFab_desc = fabricante.FAB_DESC;
        }

    }
}
