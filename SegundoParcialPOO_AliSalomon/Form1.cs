using SegundoParcialPOO_AliSalomon.CarpetaGimnasio;
using SegundoParcialPOO_AliSalomon.CarpetaSocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;
using SegundoParcialPOO_AliSalomon.CarpetaCuota;
using SegundoParcialPOO_AliSalomon.CarpetaEvento;
using System.Globalization;

namespace SegundoParcialPOO_AliSalomon
{
    public partial class Form1 : Form
    {
        Gimnasio controles;
        public Form1()
        {
            InitializeComponent();
            controles = new Gimnasio();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ConfiguroMisGrillas(new List<DataGridView>() { dtgvSocio, dtgvCuotasDelClienteSeleccionado, dtgvCuotasPagadasDelSocioSeleccionado, dtgvPagosOrdenados, dtgvTodasCuotasPagadas });
        }

        #region Configuracion DataGridView
        private void ConfiguroMisGrillas(List<DataGridView> pDtgv)
        {
            foreach (DataGridView dgv in pDtgv)
            {
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.MultiSelect = false;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.RowHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
                dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Blue;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void RefrescaGrillas(DataGridView pDtgv, Object pO)
        {
            pDtgv.DataSource = null;
            pDtgv.DataSource = pO;
        }

        public object TodosPagosLinQ()
        {
            return (from cuota in controles.ListaDeCuotasPagadasClub()
                    select new
                    {
                        Socio = cuota.RetornaSocio().Nombre,
                        Importe = "$ " + cuota.Pago,
                    }).ToList();
        }
        #endregion

        #region ABM Socio
        private void btnSocioAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Socio socio = null;
                if (radioButtonComun.Checked) socio = new SocioComun();
                if (radioButtonEspecial.Checked) socio = new SocioEspecial();

                if(radioButtonComun.Checked || radioButtonEspecial.Checked)
                {
                    string legajo = Interaction.InputBox("Ingrese el legajo: (4 digitos)", "Alta de socio");
                    if (controles.RetornaSocios().Exists(x => x.Legajo == legajo)) throw new Exception("Socio ya se encuentra registrado/a");
                    if (legajo.Length > 4) throw new Exception("El legajo contiene 4 digitos");
                    var legajovalid = new Regex(@"\d{4}");
                    if (!legajovalid.IsMatch(legajo)) throw new Exception("debe ingresar el legajo numerico de 4 digitos.");

                    string nombre = Interaction.InputBox($"Nombre:\n{Environment.NewLine}" +
                                                         $"Legajo: {legajo}", "Alta de socio").ToUpper();
                    if (nombre == "") throw new Exception("Debe ingresar un nombre.");
                    if (Information.IsNumeric(nombre)) throw new Exception("El nombre no puede contener numeros.");

                    string apellido = Interaction.InputBox($"Apellido:\n{Environment.NewLine}" +
                                                           $"Legajo: {legajo}\n{nombre}", "Alta de socio").ToUpper();
                    if (apellido == "") throw new Exception("Debe ingresar un apellido.");
                    if (Information.IsNumeric(apellido)) throw new Exception("El apellido no puede contener numeros.");

                    socio.Legajo = legajo;
                    socio.Nombre = nombre;
                    socio.Apellido = apellido;

                    controles.AgregarSocio(socio);
                    RefrescaGrillas(dtgvSocio, controles.RetornaSocios());
                    
                    socio.Dispose();
                }
                else throw new Exception("Debe elegir el tipo de socio.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSocioModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvSocio.Rows.Count == 0) throw new Exception("No hay socios registrados para modificar.");
                Socio auxiliar = (Socio)dtgvSocio.SelectedRows[0].DataBoundItem;

                auxiliar.Nombre = Interaction.InputBox($"Nombre:\n{Environment.NewLine}" +
                                                         $"Legajo: {auxiliar.Legajo}", "Modificando...").ToUpper();
                if (Information.IsNumeric(auxiliar.Nombre)) throw new Exception("El nuevo nombre no puede contener numeros.");
                if (auxiliar.Nombre == "") throw new Exception("no se puede dejar el nombre en blanco");

                auxiliar.Apellido = Interaction.InputBox($"Apellido:\n{Environment.NewLine}" +
                                                           $"Legajo: {auxiliar.Legajo}\n{auxiliar.Nombre}", "Modificando...").ToUpper();
                if (Information.IsNumeric(auxiliar.Apellido)) throw new Exception("El nuevo apellido no puede contener numeros.");
                if (auxiliar.Apellido == "") throw new Exception("no se puede dejar el apellido en blanco");


                controles.ModificaSocio(auxiliar);
                dtgvSocio_RowEnter(null, null);
                RefrescaGrillas(dtgvSocio, controles.RetornaSocios());
                               
                auxiliar.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSocioBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvSocio.Rows.Count == 0) throw new Exception("No hay socios registrados para borrar.");
                Socio auxiliar = (Socio)dtgvSocio.SelectedRows[0].DataBoundItem;

                controles.BorrarSocio(auxiliar);
                RefrescaGrillas(dtgvSocio, controles.RetornaSocios());
                dtgvSocio_RowEnter(null, null);

                auxiliar.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region ABM Cuota
        private void btnCuotaAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvSocio.Rows.Count == 0) throw new Exception("No puede crear una cuota si no hay socios registrados");
                Socio socio = (Socio)dtgvSocio.SelectedRows[0].DataBoundItem;

                if (socio.DevuelveListaCuotasPropio().Count < 2)
                {
                    string codigo = Interaction.InputBox($"Codigo: (6 digitos)\n\nCargando cuota para {socio.Nombre} {socio.Apellido}", "Cuota");
                    if (controles.RetornaCuotas().Exists(x => x.Codigo.ToString() == codigo)) throw new Exception("La cuota ya se encuentra registrada");
                    if (codigo.Length > 6) throw new Exception("El codigo debe ser de 6 digitos numericos.");
                    var codigoValid = new Regex(@"\d{6}");
                    if (!codigoValid.IsMatch(codigo)) throw new Exception("El codigo debe ser de 6 digitos.");

                    CultureInfo ci = new CultureInfo("es-ES");

                    DateTime fechacorresponde = DateTime.Now;
                    DateTime fechavencimiento = fechacorresponde.AddMonths(1);

                    if(socio._cuotasPropia.Count > 0) // si el socio tiene una cuota
                    {
                        //la segunda que le asigno individualmente le corresponde al siguiente mes

                        DateTime FechacorrespondeSegundo = fechacorresponde.AddMonths(1);
                        DateTime FechaVencimientoSegundo = fechavencimiento.AddMonths(1);

                        decimal importe = Convert.ToDecimal(Interaction.InputBox($"Importe:\n\n" +
                        $"Socio: {socio.Nombre} {socio.Apellido}\n\n" +
                        $"Fecha Otorgada: {FechacorrespondeSegundo.ToString("MMMM", ci).ToUpper() + "/" + fechacorresponde.ToString("yyyy")}\n" +
                        $"Vencimiento: {FechaVencimientoSegundo.ToString("MMMM", ci).ToUpper() + "/" + fechavencimiento.ToString("yyyy")}", "Cuota"));
                        if (importe == 0) throw new Exception("El importe no puede ser cero.");
                        if (!Information.IsNumeric(importe)) throw new Exception("El importe debe ser numerico.");

                        Cuota cuota = new Cuota(Convert.ToInt32(codigo), FechacorrespondeSegundo.ToString("dd/MM/yyy"), FechaVencimientoSegundo.ToString("dd/MM/yyyy"), importe, socio);

                        controles.AsignarCuota(socio, cuota);
                        RefrescaGrillas(dtgvSocio, controles.RetornaSocios());
                        dtgvSocio_RowEnter(null, null);

                        socio.Dispose();
                        cuota.Dispose();
                    }
                    else
                    {
                        decimal importe = Convert.ToDecimal(Interaction.InputBox($"Importe:\n\n" +
                        $"Socio: {socio.Nombre} {socio.Apellido}\n\n" +
                        $"Fecha Otorgada: {fechacorresponde.ToString("MMMM", ci).ToUpper() + "/" + fechacorresponde.ToString("yyyy")}\n" +
                        $"Vencimiento: {fechavencimiento.ToString("MMMM", ci).ToUpper() + "/" + fechavencimiento.ToString("yyyy")}", "Cuota"));
                        if (importe == 0) throw new Exception("El importe no puede ser cero.");
                        if (!Information.IsNumeric(importe)) throw new Exception("El importe debe ser numerico.");

                        Cuota cuota = new Cuota(Convert.ToInt32(codigo), fechacorresponde.ToString("dd/MM/yyy"), fechavencimiento.ToString("dd/MM/yyyy"), importe, socio);

                        controles.AsignarCuota(socio, cuota);
                        RefrescaGrillas(dtgvSocio, controles.RetornaSocios());
                        dtgvSocio_RowEnter(null, null);

                        socio.Dispose();
                        cuota.Dispose();
                    }
                }
                else throw new Exception($"{socio.Nombre} {socio.Apellido} ya esta adeudado 2 cuotas");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region DataGrid Socio RowEnter
        private void dtgvSocio_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgvSocio.SelectedRows.Count > 0)
                {
                    Socio socio = (Socio)dtgvSocio.SelectedRows[0].DataBoundItem;
                    RefrescaGrillas(dtgvCuotasDelClienteSeleccionado, controles.DevuelveListaCuotaDeSocio(socio));
                    RefrescaGrillas(dtgvCuotasPagadasDelSocioSeleccionado, (from LinQpagadas in controles.DevuelveListaCuotaPagadoDeSocio(socio) select LinQpagadas).ToArray());
                    RefrescaGrillas(dtgvPagosOrdenados, controles.DevuelveListaCuotaPagadoDeSocio(socio));               
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Pagar
        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvSocio.Rows.Count == 0) throw new Exception("No hay socios registrado");
                if (dtgvCuotasDelClienteSeleccionado.Rows.Count == 0) throw new Exception("Socio no tiene cuotas a pagar");

                Socio socio = (Socio)dtgvSocio.SelectedRows[0].DataBoundItem;
                Cuota cuota = (Cuota)dtgvCuotasDelClienteSeleccionado.SelectedRows[0].DataBoundItem;

                DateTime FechaAbonando = Convert.ToDateTime(Interaction.InputBox($"Ingrese la fecha en la que se esta realizando el pago: (dd/MM/yyy) \n\n" +
                    $"Vencimiento: {cuota.Vencimiento}\n\n", "Pago de cuota"));

                socio.PagoMayor10k += MensajeMasDe10K;

                socio.PagarCuota(cuota, cuota.Importe, FechaAbonando);

                decimal ImporteExtra = cuota.Pago - cuota.Importe;
                var consulta = MessageBox.Show($"Desea cobrar la cuota?\n\n" +
                    $"Socio: {socio}\n" +
                    $"Valor de cuota: + $ {cuota.Importe}\n" +
                    $"Importe extra:  + $ {ImporteExtra}\n" +
                    $"----------------------------------\n" +
                    $"Total a Cobrar:  + $ {cuota.Pago}", "Pago de cuota", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (consulta == DialogResult.Yes)
                {
                    controles.PagadaCuota(cuota, socio);
                    socio.PagoMayor10k -= MensajeMasDe10K;
                }
                else throw new Exception("Pago Cancelado");
                RefrescaGrillas(dtgvSocio, controles.RetornaSocios());
                RefrescaGrillas(dtgvTodasCuotasPagadas, TodosPagosLinQ());
                dtgvSocio_RowEnter(null, null);

                socio.Dispose();
                cuota.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Genera Cuota a todos
        private void btnGeneraCuotaATodos_Click(object sender, EventArgs e)
        {
            try
            {
                Random r;
                if (dtgvSocio.Rows.Count == 0) throw new Exception("Debe haber almenos 1 socio registrado para usar esta funcionalidad.");
                if (dtgvSocio.Rows.Count > 0)
                {
                    CultureInfo ci = new CultureInfo("es-ES");

                    DateTime fechacorresponde = Convert.ToDateTime(Interaction.InputBox("Ingrese fecha correspondiente de la cuota: (dd/MM/yyyy)", "Cuota a todos los socios"));
                    if (!Information.IsDate(fechacorresponde)) throw new Exception("Debe respetar el formato de fecha que indica y elegir una vecha valida.");
                    if (fechacorresponde < DateTime.Now) throw new Exception("No puede crear una cuota que corresponda antes del dia de hoy");
                    DateTime fechavencimiento = fechacorresponde.AddMonths(1);

                    decimal importe = Convert.ToDecimal(Interaction.InputBox($"Importe: \n\n" +
                        $"Fecha Otorgada: {fechacorresponde.ToString("MMMM", ci).ToUpper() + "/" + fechacorresponde.ToString("yyyy")}\n" +
                        $"Vencimiento: {fechavencimiento.ToString("MMMM", ci).ToUpper() + "/" + fechavencimiento.ToString("yyyy")}", "Cuota a todos los socios"));
                    if (importe == 0) throw new Exception("El importe no puede ser cero.");
                    if (!Information.IsNumeric(importe)) throw new Exception("El importe debe ser numerico.");

                    foreach(Socio socio in controles.RetornaSocios())
                    {
                        if(socio._cuotasPropia.Count < 2) // si socios tienen menor que 2 cuotas
                        {
                            r = new Random();
                            int codigo = r.Next(1000000);

                            if (socio._cuotasPropia.Count > 0) //si algun socio tiene al menos una cuota propia
                            {
                                //llamo a metodo que me retorna la fecha de su cuota 
                                if(controles.RetornaFechaDeCuota(socio, socio._cuotasPropia[0]).Month != fechacorresponde.Month) //y esa cuota NO corresponde al mismo mes del ingresado!
                                {
                                    Cuota cuota = new Cuota(Convert.ToInt32(codigo), fechacorresponde.ToString("dd/MM/yyy"), fechavencimiento.ToString("dd/MM/yyyy"), importe, socio);

                                    controles.AsignarCuota(socio, cuota);
                                    RefrescaGrillas(dtgvSocio, controles.RetornaSocios());
                                    dtgvSocio_RowEnter(null, null);

                                    socio.Dispose();
                                    cuota.Dispose();
                                }
                            }
                            else
                            {
                                Cuota cuota = new Cuota(Convert.ToInt32(codigo), fechacorresponde.ToString("dd/MM/yyy"), fechavencimiento.ToString("dd/MM/yyyy"), importe, socio);

                                controles.AsignarCuota(socio, cuota);
                                RefrescaGrillas(dtgvSocio, controles.RetornaSocios());
                                dtgvSocio_RowEnter(null, null);

                                socio.Dispose();
                                cuota.Dispose();
                            }
                        }
                    }
                    dtgvSocio_RowEnter(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region RadioButtons DataGrid Pagos del Socio
        private void radioButtonMayorAMenor_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvSocio.SelectedRows.Count == 1)
                {
                    Socio socio = (Socio)dtgvSocio.SelectedRows[0].DataBoundItem;
                    socio._cuotasPagadas.ToArray();
                    socio._cuotasPagadas.Sort(new Socio.PagoDescendente());
                    RefrescaGrillas(dtgvPagosOrdenados, socio.DevuelveListaCuotasPropioPagado());
                }
                else throw new Exception("No hay socio seleccionado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonMenorAMayor_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvSocio.SelectedRows.Count == 1)
                {
                    Socio socio = (Socio)dtgvSocio.SelectedRows[0].DataBoundItem;
                    socio._cuotasPagadas.ToArray();
                    socio._cuotasPagadas.Sort(new Socio.PagoAscendente());
                    RefrescaGrillas(dtgvPagosOrdenados, socio.DevuelveListaCuotasPropioPagado());
                }
                else throw new Exception("No hay socio seleccionado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Evento
        private void MensajeMasDe10K(object sender, MasDe10kEventArgs e)
        {
            MessageBox.Show($"El importe a pagar supera los $10,000!\n\n" +
                $"El valor total a pagar es $ {e.ImporteAdeudado}\n¡Avise al socio! Si no paga la cuota adeudado debera prohibir la entrada al socio."
                            , "AVISO DE PAGOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion
    }
}
