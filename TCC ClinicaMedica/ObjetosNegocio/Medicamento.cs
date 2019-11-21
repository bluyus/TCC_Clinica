using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{
    public class Medicamento
    {
        public int Id { get; set; }

        public string NomeGenerico { get; set; }

        public string NomeComercial { get; set; }

        public string Fabricante { get; set; }
    }
}
