using SegundoParcialPOO_AliSalomon.CarpetaCuota;
using SegundoParcialPOO_AliSalomon.CarpetaSocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcialPOO_AliSalomon.CarpetaGimnasio
{
    public class Gimnasio
    {
        List<Socio> _listaSocios;
        List<Cuota> _listaCuotas;
        List<Cuota> _listaCuotasPagadas;

        public Gimnasio()
        {
            _listaSocios = new List<Socio>();
            _listaCuotas = new List<Cuota>();
            _listaCuotasPagadas = new List<Cuota>();
        }

        #region ABM Socio
        public void AgregarSocio(Socio pSocio)
        {
            try
            {
                if (pSocio == null) throw new Exception("Error. El inversor no existe");

                if (pSocio.GetType().Name == "SocioComun")
                {
                    SocioComun comun = new SocioComun();
                    comun.Legajo = pSocio.Legajo;
                    comun.Nombre = pSocio.Nombre;
                    comun.Apellido = pSocio.Apellido;
                    _listaSocios.Add(comun);
                }
                else if (pSocio.GetType().Name == "SocioEspecial")
                {
                    SocioEspecial especial = new SocioEspecial();
                    especial.Legajo = pSocio.Legajo;
                    especial.Nombre = pSocio.Nombre;
                    especial.Apellido = pSocio.Apellido;
                    _listaSocios.Add(especial);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ModificaSocio(Socio pSocio)
        {
            try
            {
                Socio auxiliar = _listaSocios.Find(x => x.Legajo == pSocio.Legajo);
                if (auxiliar == null) throw new Exception("El socio que desea modificar no existe.");

                //if (pSocio.Nombre == "" || pSocio.Apellido == "") throw new Exception("No puede dejar en blanco el nombre y/o el apellido");
                auxiliar.Nombre = pSocio.Nombre;
                auxiliar.Apellido = pSocio.Apellido;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BorrarSocio(Socio pSocio)
        {
            try
            {
                if (!_listaSocios.Exists(x => x.Legajo == pSocio.Legajo)) throw new Exception("El socio que desea borrar no existe");

                if (pSocio._cuotasPropia.Count > 0) throw new Exception("No puede borrar socio que adeuda al menos 1 cuota.");
                else _listaSocios.Remove(_listaSocios.Find(x => x.Legajo == pSocio.Legajo));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Asignar Cuota y Pagada
        public void AsignarCuota(Socio pSocio, Cuota pCuota)
        {
            try
            {
                Socio socioseleccionado = _listaSocios.Find(x => x.Legajo == pSocio.Legajo);
                Cuota cuotaseleccionado = pCuota;

                if (socioseleccionado == null) throw new Exception("Socio no existe!");
                if (cuotaseleccionado == null) throw new Exception("La cuota no existe!");

                cuotaseleccionado.AsignarSocio(socioseleccionado);
                socioseleccionado.AsignarCuota(cuotaseleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PagadaCuota(Cuota pCuota, Socio pSocio)
        {
            try
            {
                if (!pSocio._cuotasPropia.Exists(x => x.Codigo == pCuota.Codigo)) throw new Exception("La cuota que desea pagar no existe");
                pSocio._cuotasPagadas.Add(pCuota); //lo agrego a mi lista de cuotas pagadas antes de borrar
                _listaCuotasPagadas.Add(pCuota);
                pSocio._cuotasPropia.Remove(pSocio._cuotasPropia.Find(x => x.Codigo == pCuota.Codigo));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DateTime RetornaFechaDeCuota(Socio socio, Cuota cuota)
        {
            Socio aux = _listaSocios.Find(x => x.Legajo == socio.Legajo);
            Cuota aux2 = aux._cuotasPropia.Find(x => x.FechaCorresponde == cuota.FechaCorresponde);

            return Convert.ToDateTime(aux2.FechaCorresponde.ToString());

        }
        #endregion

        #region Retorna listas
        public List<Socio> RetornaSocios()
        {
            List<Socio> listaclon = new List<Socio>();
            foreach(var socio in _listaSocios)
            {
                listaclon.Add(socio);
            }
            return listaclon;
        }
        public List<Cuota> RetornaCuotas()
        {
            List<Cuota> listaClon = new List<Cuota>();
            foreach(var cuota in _listaCuotas)
            {
                listaClon.Add(cuota);
            }
            return listaClon;
        }
        public List<Cuota> DevuelveListaCuotaDeSocio(Socio pSocio)
        {
            Socio socio = _listaSocios.Find(x => x.Legajo == pSocio.Legajo);
            return socio.DevuelveListaCuotasPropio();
        }
        public List<Cuota> DevuelveListaCuotaPagadoDeSocio(Socio pSocio)
        {
            Socio socio = _listaSocios.Find(x => x.Legajo == pSocio.Legajo);
            return socio.DevuelveListaCuotasPropioPagado();
        }
        public List<Cuota> ListaDeCuotasPagadasClub()
        {
            return _listaCuotasPagadas;
        }
        #endregion

    }
}
