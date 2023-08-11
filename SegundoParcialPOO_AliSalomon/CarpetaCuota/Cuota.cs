using SegundoParcialPOO_AliSalomon.CarpetaSocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialPOO_AliSalomon.CarpetaCuota
{
    public class Cuota : IDisposable
    {
        #region Propiedades
        public int Codigo { get; set; }
        public string FechaCorresponde { get; set; }
        public string Vencimiento { get; set; }
        public decimal Importe { get; set; }
        public decimal Pago { get; set; }
        public Socio SocioAsignado { get; set; }
        #endregion

        #region Constructores
        public Cuota() { }
        public Cuota(int pCodigo, string pFechaCorr, string pFechaVenc, decimal pImporte, Socio pSocio)
        {
            Codigo= pCodigo;
            FechaCorresponde= pFechaCorr;
            Vencimiento= pFechaVenc;
            Importe= pImporte;
            SocioAsignado= pSocio;
        }

        #endregion

        #region Metodos
        public void AsignarSocio(Socio pSocio)
        {
            SocioAsignado = pSocio;
        }
        public Socio RetornaSocio()
        {
            return SocioAsignado;
        }
        #endregion

        public override string ToString()
        {
            return $"Codigo: {Codigo}, ${Importe}";
        }

        #region IDisposable
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
