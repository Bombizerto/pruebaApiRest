using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AccesoDatos.POGO
{
   public class Terminal
    {

        private int _id_terminal;
        public int vId_terminal
        {
            get { return _id_terminal; }
            set { _id_terminal = value; }
        }
        private DateTime _fecha_fabricacion;
        public DateTime vFecha_fabricacion
        {
            get { return _fecha_fabricacion; }
            set { _fecha_fabricacion = value; }
        }
        private DateTime _fecha_estado;
        public DateTime vFecha_estado
        {
            get { return _fecha_estado; }
            set { _fecha_estado = value; }
        }

        private String _terminal_desc;
        public String vTerminal_desc
        {
            get { return _terminal_desc; }
            set { _terminal_desc = value; }
        }
        private String _terminal_name;
        public String vTerminal_name
        {
            get { return _terminal_name; }
            set { _terminal_name = value; }
        }
        private Estado _estado;
        public Estado vEstado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        private Fabricante _fabricante;
        public Fabricante vFabricante
        {
            get { return _fabricante; }
            set { _fabricante = value; }
        }
        public Terminal(TERMINALES terminal)
        {
            if (terminal != null)
            {
                vId_terminal = Convert.ToInt32(terminal.ID_TERMINAL);
                vFecha_fabricacion = (DateTime)terminal.FECHA_FABRICACION;
                vFecha_estado = (DateTime)terminal.FECHA_ESTADO;
                vTerminal_desc = terminal.TERMINAL_DESC;
                vTerminal_name = terminal.TERMINAL_NAME;
                vFabricante = new Fabricante(terminal.FABRICANTES);
                vEstado = new Estado(terminal.ESTADO);
            }
           
        }        
    }
}
