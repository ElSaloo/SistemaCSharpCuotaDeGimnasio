using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialPOO_AliSalomon.CarpetaEvento
{
    public class MasDe10kEventArgs : EventArgs
    {
        decimal importeadeudado;
        public decimal ImporteAdeudado { get { return importeadeudado; } }
        public MasDe10kEventArgs(decimal pImporteAdeudado)
        {
            importeadeudado= pImporteAdeudado;
        }
    }
}
