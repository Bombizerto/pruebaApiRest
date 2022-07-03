using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.POGO
{
    public class Terminales
    {
        private List<Terminal> _terminales;
        public List<Terminal> vTerminales
        {
            get { return _terminales; }
            set { _terminales = value; }
        }
        public Terminales(List<TERMINALES> Terminales)
        {
            vTerminales = new List<Terminal>();
            foreach(TERMINALES terminal in Terminales)
            {
                vTerminales.Add(new Terminal(terminal));
            }
        }
        public Terminales()
        {
            vTerminales = new List<Terminal>();
        }
    }
}
