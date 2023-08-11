using SegundoParcialPOO_AliSalomon.CarpetaCuota;
using SegundoParcialPOO_AliSalomon.CarpetaEvento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialPOO_AliSalomon.CarpetaSocio
{
    public abstract class Socio : IDisposable
    {
        #region Propiedades
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Cuota> _cuotasPropia { get; set; }
        public List<Cuota> _cuotasPagadas { get; set; }

        public event EventHandler<MasDe10kEventArgs> PagoMayor10k;
        #endregion

        #region Evento
        protected virtual void DebeMasDe10k(decimal pImporte)
        {
            PagoMayor10k?.Invoke(this, new MasDe10kEventArgs(pImporte));
        }
        #endregion

        #region Constructor
        public Socio()
        {
            _cuotasPropia = new List<Cuota>();
            _cuotasPagadas= new List<Cuota>();
        }
        #endregion

        #region Metodos
        public void AsignarCuota(Cuota cuota)
        {
            this._cuotasPropia.Add(cuota);
        }
        public List<Cuota> DevuelveListaCuotasPropio()
        {
            List<Cuota> listaClon = new List<Cuota>();
            foreach(var cuota in _cuotasPropia)
            {
                listaClon.Add(cuota);
            }
            return listaClon;
        }
        public List<Cuota> DevuelveListaCuotasPropioPagado()
        {
            List<Cuota> listaClon = new List<Cuota>();
            foreach (var cuota in _cuotasPagadas)
            {
                listaClon.Add(cuota);
            }
            return listaClon;
        }
        #endregion

        #region Metodo Polimorfico
        public abstract void PagarCuota(Cuota pCuota, decimal pImporte, DateTime pFechaabonando);
        #endregion
        public override string ToString()
        {
            return $"Legajo: {Legajo} | {Nombre} {Apellido}";
        }
        #region IDisposable ICloneable IComparer
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public class PagoAscendente : IComparer<Cuota>
        {
            public int Compare(Cuota x, Cuota y)
            {
                int resultado = 0;
                if (x.Pago > y.Pago) resultado = 1;
                if (y.Pago > x.Pago) resultado = -1;
                return resultado;
            }
        }
        public class PagoDescendente : IComparer<Cuota>
        {
            public int Compare(Cuota x, Cuota y)
            {
                int resultado = 0;
                if (x.Pago > y.Pago) resultado = -1;
                if (y.Pago > x.Pago) resultado = 1;
                return resultado;
            }
        }

        #endregion

    }
}
