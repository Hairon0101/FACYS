using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FacSys.Clases;

namespace FacSys
{
    public partial class Apertura_De_Cuenta : DevExpress.XtraEditors.XtraForm
    {
        public Apertura_De_Cuenta()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            //ativo los controles
            cmbTiposCuentas.Enabled = true;
            cmboficina.Enabled = true;
            txtCliente.Enabled = true;
            txtMontoMinimoApertura.Enabled = true;
            
            chkGanaInteres.Enabled = true;
            chkPermitirSobregiros.Enabled = true;
            /////////
            btnNuevo.Enabled = false;

            // instancio la clase 
            Cuentas cuenta = new Cuentas();

            txtidcuenta.Text = cuenta.ConsultaCuenta(1.ToString());
            cmbTiposCuentas.Focus();
            txtfecha.EditValue = DateTime.Now.Date;

            cuenta.CargarComboBox(cmbTiposCuentas);
            cuenta.CargarComboBoxOficinas(cmboficina);



        }

        private void cmbTiposCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbTiposCuentas.Text) || string.IsNullOrWhiteSpace(cmbTiposCuentas.Text)) return;

            Cuentas cuenta = new Cuentas();

            txtTipoCuenta.Text = cuenta.NombreTipoCuenta(cmbTiposCuentas.Text);
        }

        private void Apertura_De_Cuenta_Load(object sender, EventArgs e)
        {
            Cuentas cuenta = new Cuentas();


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtidcuenta.ResetText();
            txtTipoCuenta.ResetText();
            txtNombreCliente.ResetText();
            txtOficna.ResetText();
            cmboficina.ResetText();
            cmbTiposCuentas.ResetText();
            chkGanaInteres.Checked = false;
            chkPermitirSobregiros.Checked = false;
            txtCliente.ResetText();
            txtMontoMinimoApertura.ResetText();
            txtMontoEfectivo.ResetText();
            
            txtfecha.ResetText();


            // desativo los controles nuevamente
            //ativo los controles
            cmbTiposCuentas.Enabled = false;
            cmboficina.Enabled = false;
            txtCliente.Enabled = false;
            txtMontoMinimoApertura.Enabled = false;
            
            chkGanaInteres.Enabled = false;
            chkPermitirSobregiros.Enabled = false;

            //////
            btnNuevo.Enabled = true;
            
        }
        
        private void txtCliente_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCliente.Text) || string.IsNullOrWhiteSpace(txtCliente.Text)) return;

            Cuentas cuenta = new Cuentas();

            txtNombreCliente.Text = cuenta.NombreCliente(txtCliente.Text);
        }

        private void cmboficina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmboficina.Text) || string.IsNullOrWhiteSpace(cmboficina.Text)) return;

            Cuentas cuenta = new Cuentas();

            txtOficna.Text = cuenta.NombreOficina(cmboficina.Text);
        }

        private void btnApertura_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidcuenta.Text) || string.IsNullOrWhiteSpace(txtidcuenta.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(cmbTiposCuentas.Text) || string.IsNullOrWhiteSpace(cmbTiposCuentas.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(cmboficina.Text) || string.IsNullOrWhiteSpace(cmboficina.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtCliente.Text) || string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtMontoMinimoApertura.Text) || string.IsNullOrWhiteSpace(txtMontoMinimoApertura.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtMontoEfectivo.Text) || string.IsNullOrWhiteSpace(txtMontoEfectivo.Text))
            {
                return;
            }

            Cuentas cuenta = new Cuentas();
            cuenta.GuardarCuenta(txtidcuenta.Text, Convert.ToInt32(cmbTiposCuentas.Text), Convert.ToInt32(cmboficina.Text), 
                                 txtNombreCliente.Text, txtCliente.Text,Convert.ToDateTime(txtfecha.EditValue.ToString()), Convert.ToDouble(txtMontoEfectivo.Text), chkGanaInteres.Checked, chkPermitirSobregiros.Checked);
            btncancelar_Click(btncancelar, e);
        }
    }
    
}