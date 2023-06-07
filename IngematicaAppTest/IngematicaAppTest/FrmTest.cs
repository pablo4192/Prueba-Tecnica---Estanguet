using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IngematicaAppTest.Model;
using IngematicaAppTest.Service;




namespace IngematicaAppTest
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();

            InitializeCombos();
        }


        private void InitializeCombos()
        {
            InitializeComboTipoTransporte();

            InitializeCoboLocalidad();

        }

        private void InitializeComboTipoTransporte()
        {
            List<TipoTransporteModel> tipoTransporteList = new List<TipoTransporteModel>();
            TipoTransporteService tipoTransporteService = new TipoTransporteService();
            tipoTransporteList = tipoTransporteService.GetList();

            var bindingSourceTipoTransporte = new BindingSource();
            bindingSourceTipoTransporte.DataSource = tipoTransporteList;

            cbTipoTransporte.DataSource = bindingSourceTipoTransporte;
            cbTipoTransporte.DisplayMember = "Nombre";
            cbTipoTransporte.ValueMember = "IdTipoTransporte";
        }

        private void InitializeCoboLocalidad()
        {
            List<LocalidadModel> localidadList = new List<LocalidadModel>();
            LocalidadService localidadService = new LocalidadService();
            localidadList = localidadService.GetList();

            var bindingSourceLocalidad = new BindingSource();
            bindingSourceLocalidad.DataSource = localidadList;

            cbLocalidadDestino.DataSource = bindingSourceLocalidad;
            cbLocalidadDestino.DisplayMember = "Nombre";
            cbLocalidadDestino.ValueMember = "IdLocalidad";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> fechaEstimadaLlegada = new Dictionary<string, string>();
            LocalidadService locServ = new LocalidadService();
            TipoTransporteService tipoTransServ = new TipoTransporteService();

            int idLocalidad = (int) this.cbLocalidadDestino.SelectedValue;
            int idTipoTransporte = (int)this.cbTipoTransporte.SelectedValue;
            
            DateTime fechaInicial = this.dtpFechaInicial.Value;
            string tipoCamino = this.rdbRuta.Checked ? "ruta" : "autopista";

            LocalidadModel localidad = locServ.GetById(idLocalidad);
            TipoTransporteModel tipoTransporte = tipoTransServ.GetById(idTipoTransporte);

            if(!this.rdbAutopista.Checked && !this.rdbRuta.Checked)
            {
                this.lblAvisoCamino.Visible = true;
            }
            else
            {
                this.lblAvisoCamino.Visible = false;
                fechaEstimadaLlegada = CalculoService.CalcularLlegada(localidad, tipoTransporte, fechaInicial, tipoCamino);
                this.txtDiasDemora.Text = fechaEstimadaLlegada["dias_demora"];
                this.txtFechaLlegada.Text = fechaEstimadaLlegada["fecha_llegada"];
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            this.txtFechaLlegada.Text = string.Empty;
            this.txtDiasDemora.Text = string.Empty;
            this.rdbRuta.Checked = false;
            this.rdbAutopista.Checked = false;
            this.lblAvisoCamino.Visible = false;
        }

    }
}
