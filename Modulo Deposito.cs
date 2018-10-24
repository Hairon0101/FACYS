using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacSys
{
    public partial class FrmDeposito : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmDeposito()
        {
            InitializeComponent();
            
        }
        private bool IsFormActived(Form form)
        {
            bool IsOpened = false;

            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form.Name == item.Name)
                    {
                        xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                        IsOpened = true;
                    }
                }
            }
            return IsOpened;
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form aper = new Apertura_De_Cuenta();

            aper.Name = barButtonItem6.Caption;
            if (!IsFormActived(aper))
            {
                aper.MdiParent = this;
                aper.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form tipo = new Tipos_De_Cuentas();
            tipo.Name = barButtonItem3.Caption;

            if (!IsFormActived(tipo))
            {
                tipo.MdiParent = this;
                tipo.Show();
            }
        }

        private void btnCrearCuentas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            
        }

        private void btnBancos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form banco = new Creacion_De_Bancos();
            banco.Name = btnBancos.Caption;

            if (!IsFormActived(banco))
            {
                banco.MdiParent = this;
                banco.Show();
            }
        }

        private void btnAperturarCuenta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form apertura = new Apertura_De_Cuenta();
            apertura.Name = btnAperturarCuenta.Caption;

            if (!IsFormActived(apertura))
            {
                apertura.MdiParent = this;
                apertura.Show();
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
