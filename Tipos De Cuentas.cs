using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FacSys.Clases;

namespace FacSys
{
    public partial class Tipos_De_Cuentas : DevExpress.XtraEditors.XtraForm
    {
        public Tipos_De_Cuentas()
        {
            InitializeComponent();
        }

        private void btnNueno_Click(object sender, EventArgs e)
        {
            btnCancelar_Click(btnCancelar, e);

            txtIdTipoCuenta.Properties.ReadOnly = true;

            TiposCuentas tipos = new TiposCuentas();

            txtIdTipoCuenta.Text = Convert.ToString( tipos.ConsultaTipoCuenta());
            txtDescripcion.Focus();
            
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdTipoCuenta.ResetText();
            txtIdTipoCuenta.Properties.ReadOnly = false;
            txtDescripcion.ResetText();
            txtMontoMaximo.ResetText();
            txtMontoMinimo.ResetText();
            txtMontoMinimoApertura.ResetText();
            txtTasa.ResetText();
            SpnDias.ResetText();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdTipoCuenta.Text) || string.IsNullOrWhiteSpace(txtIdTipoCuenta.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtIdTipoCuenta.Text) || string.IsNullOrWhiteSpace(txtIdTipoCuenta.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtMontoMaximo.Text) || string.IsNullOrWhiteSpace(txtMontoMaximo.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtMontoMinimo.Text) || string.IsNullOrWhiteSpace(txtMontoMinimo.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtMontoMinimoApertura.Text) || string.IsNullOrWhiteSpace(txtMontoMinimoApertura.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtTasa.Text) || string.IsNullOrWhiteSpace(txtTasa.Text))
            {
                return;
            }

            if (string.IsNullOrEmpty(SpnDias.Text) || string.IsNullOrWhiteSpace(SpnDias.Text))
            {
                return;
            }

            

           
                TiposCuentas tipos = new TiposCuentas();
                tipos.GuardarTiposCuentas(Convert.ToInt32(txtIdTipoCuenta.Text),txtDescripcion.Text,Convert.ToInt32(SpnDias.Value), 
                                           Convert.ToDouble(txtMontoMinimoApertura.Text), Convert.ToDouble(txtMontoMinimo.Text), Convert.ToDouble(txtMontoMaximo.Text),
                                           Convert.ToDouble(txtTasa.Text));


                if (tipos.ResultadoGuardarTipoCuentas ==true)
                {

                    XtraMessageBox.SmartTextWrap = true;
                    MessageBox.Show("Datos Guardao Con Exito");
                btnCancelar_Click(btnCancelar, e);
            }
            else
            {
                XtraMessageBox.SmartTextWrap = true;
                MessageBox.Show("No se pudo insertar el registro");

            }



            }

        private void txtIdTipoCuenta_MouseClick(object sender, MouseEventArgs e)
        {

        }

     

        private void txtIdTipoCuenta_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdTipoCuenta.Text) || string.IsNullOrWhiteSpace(txtIdTipoCuenta.Text))
            {
                return;
            }

            TiposCuentas tipos = new TiposCuentas();
            DataTable dt = tipos.CargarCuentas(txtIdTipoCuenta.Text);

            if (dt.Rows.Count >0)
            {
                txtIdTipoCuenta.Text = dt.Rows[0]["idtipo_cuenta"].ToString();
                txtDescripcion.Text = dt.Rows[0]["Descripcion"].ToString();
                SpnDias.Value =Convert.ToInt32( dt.Rows[0]["dias_inactivar_cuenta"].ToString());
                txtMontoMinimo.Text = Convert.ToDouble(dt.Rows[0]["Monto_Minimo"].ToString()).ToString("N");
                txtMontoMinimoApertura.Text = Convert.ToDouble(dt.Rows[0]["Monto_Minimo_Apertura"].ToString()).ToString("N");
                txtMontoMaximo.Text = Convert.ToDouble( dt.Rows[0]["Monto_Maximo"].ToString()).ToString("N");
                txtTasa.Text = Convert.ToDouble( dt.Rows[0]["Tasa_Interes"].ToString()).ToString("N");

                txtIdTipoCuenta.Properties.ReadOnly = true;
            }

            else
            {

                XtraMessageBox.SmartTextWrap = true;
                MessageBox.Show("No Se Encontraron Registro");

                btnCancelar_Click(btnCancelar, e);
            }
        }
        
    }
    }

