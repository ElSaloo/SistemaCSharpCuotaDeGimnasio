using SegundoParcialPOO_AliSalomon.CarpetaCuota;
using SegundoParcialPOO_AliSalomon.CarpetaEvento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialPOO_AliSalomon.CarpetaSocio
{
    public class SocioComun : Socio
    {
        public override void PagarCuota(Cuota pCuota, decimal pImporte, DateTime pFechaabonando)
        {
            if (pFechaabonando > Convert.ToDateTime(pCuota.Vencimiento))
            {
                TimeSpan TiempoSinPagar = pFechaabonando - Convert.ToDateTime(pCuota.Vencimiento);
                decimal importeExtra = TiempoSinPagar.Days * pImporte*0.05m;
                decimal TotalAPagar = pImporte + importeExtra;
                pCuota.Pago = TotalAPagar;

                if(pCuota.Pago > 10000)
                {
                    base.DebeMasDe10k(pCuota.Pago);
                }
            }
            else
            {
                pCuota.Pago = pImporte;
            }
        }
    
    }
}
