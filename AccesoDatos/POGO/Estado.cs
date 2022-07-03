using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.POGO
{
    class Estado
    {
        private int _id_estado;
        public int vId_estado
        {
            get { return _id_estado; }
            set { _id_estado = value; }
        }
        private String _estado_nombre;
        public String vEstado_nombre
        {
            get { return _estado_nombre; }
            set { _estado_nombre = value; }
        }
        private String _estado_desc;
        public String vEstado_desc
        {
            get { return _estado_nombre; }
            set { _estado_nombre = value; }
        }
        public Estado(ESTADO estado)
        {
            vId_estado =Convert.ToInt32(estado.ID_ESTADO);
            vEstado_desc = estado.ESTADO_DESC;
            vEstado_nombre = vEstado_nombre;
        }
    }
}
