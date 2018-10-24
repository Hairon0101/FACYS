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
    public partial class Creacion_De_Bancos : DevExpress.XtraEditors.XtraForm
    {
        public Creacion_De_Bancos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtidBanco.ResetText();
            txtidBanco.Properties.ReadOnly = false;
            txtDescripcion.ResetText();
            txtDireccion.ResetText();
            txtTelefono1.ResetText();
            txtTelefono2.ResetText();
            txtExt1.ResetText();
            txtExt2.ResetText();
            btnEliminar.Enabled = false;
            btnAceptar.Text = "Guardar";

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnCancelar_Click(btnCancelar, e);
            txtidBanco.Focus();

            Bancos bank = new Bancos();

            txtidBanco.Properties.ReadOnly = true;

            txtidBanco.Text = Convert.ToString(bank.ConsultaBancos());
            txtDescripcion.Focus();
            btnEliminar.Enabled = false;


           

            

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidBanco.Text) || string.IsNullOrWhiteSpace(txtidBanco.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                return;
            }

            if (string.IsNullOrEmpty(txtTelefono1.Text) || string.IsNullOrWhiteSpace(txtTelefono1.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtExt1.Text) || string.IsNullOrWhiteSpace(txtExt1.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtExt2.Text) || string.IsNullOrWhiteSpace(txtExt2.Text))
            {
                return;
            }

            Bancos bank = new Bancos();

            

            bank.GuardarBancos(Convert.ToInt32(txtidBanco.Text), txtDescripcion.Text, txtDireccion.Text,
                                       txtTelefono1.Text, txtTelefono2.Text, txtExt1.Text,txtExt2.Text,"A");

            
            if (bank.resultadoBanco == true)
            {

                if (btnAceptar.Text == "Guardar") { 
                XtraMessageBox.SmartTextWrap = true;
                MessageBox.Show("Datos Guardado Con Exito");
                
                } else
                {
                    XtraMessageBox.SmartTextWrap = true;
                    MessageBox.Show("Datos Actualizado Con Exito");

                }
                btnCancelar_Click(btnCancelar, e);
                Creacion_De_Bancos_Load(sender, e);
                btnAceptar.Text = "Guardar";
            }
            else
            {
                XtraMessageBox.SmartTextWrap = true;
                MessageBox.Show("No se pudo insertar el registro");

            }
        }

        private void Creacion_De_Bancos_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            Bancos bank = new Bancos();

            DataTable dt = bank.CargarBancoTodos();
            
            if (dt.Rows.Count > 0)
            {

                dgvConsultaBanco.AutoGenerateColumns = false;
                dgvConsultaBanco.DataSource = dt;
                dgvConsultaBanco.DataSource = null;
                dgvConsultaBanco.Rows.Clear();
                dgvConsultaBanco.DataSource = dt;
            }
            
            
        
        }

        private void dgvConsultaBanco_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidBanco.Text = dgvConsultaBanco.Rows[e.RowIndex].Cells["id_banco"].Value.ToString();
            txtDescripcion.Text = dgvConsultaBanco.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
            txtDireccion.Text = dgvConsultaBanco.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
            txtTelefono1.Text = dgvConsultaBanco.Rows[e.RowIndex].Cells["Telefono_1"].Value.ToString();
            txtTelefono2.Text = dgvConsultaBanco.Rows[e.RowIndex].Cells["Telefono_2"].Value.ToString();
            txtExt1.Text = dgvConsultaBanco.Rows[e.RowIndex].Cells["Ext_1"].Value.ToString();
            txtExt2.Text = dgvConsultaBanco.Rows[e.RowIndex].Cells["Ext_2"].Value.ToString();

            btnAceptar.Text = "Actualizar";
            
            btnEliminar.Enabled = true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (txtidBanco.Text != "")
            {
                Bancos bank = new Bancos();
                bank.EliminarBanco(txtidBanco.Text);

                if (bank.resultadoEliminar == true)

                {
                    MessageBox.Show("Registro Eliminado Con Exito");

                    int fila = dgvConsultaBanco.CurrentCell.RowIndex;
                    dgvConsultaBanco.Rows.RemoveAt(fila);

                    btnCancelar_Click(btnCancelar, e);

                }     
               


            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();        }

        private void txtidBanco_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidBanco.Text) || string.IsNullOrWhiteSpace(txtidBanco.Text))
            {
                return;
            }

            Bancos bank = new Bancos();
            DataTable dt = bank.CargarBanco(txtidBanco.Text);

            if (dt.Rows.Count > 0)
            {
                txtidBanco.Text = dt.Rows[0]["IDBANCO"].ToString();
                txtDescripcion.Text = dt.Rows[0]["Descripcion"].ToString();
                txtDireccion.Text = dt.Rows[0]["Direccion"].ToString();
                txtTelefono1.Text = dt.Rows[0]["Telefono1"].ToString();
                txtTelefono2.Text = dt.Rows[0]["Telefono2"].ToString();
                txtExt1.Text = dt.Rows[0]["Ext1"].ToString();
                txtExt2.Text = dt.Rows[0]["Ext2"].ToString();
                txtidBanco.Properties.ReadOnly = true;

                btnAceptar.Text = "Actualizar";
                btnEliminar.Enabled = true;
            }

            
        
    }
    }
}