namespace FacSys
{
    partial class FrmDeposito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeposito));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.Mantenimiento = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnTiposDeCuentas = new DevExpress.XtraBars.BarButtonItem();
            this.btnCrearCuentas = new DevExpress.XtraBars.BarButtonItem();
            this.btnEstatus = new DevExpress.XtraBars.BarButtonItem();
            this.btnBancos = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.Archivo = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnAperturarCuenta = new DevExpress.XtraBars.BarButtonItem();
            this.btnTransferencias = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.Consultas = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Archivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barSubItem1,
            this.barButtonItem2,
            this.btnTiposDeCuentas,
            this.btnCrearCuentas,
            this.btnEstatus,
            this.btnAperturarCuenta,
            this.btnTransferencias,
            this.btnSalir,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem6,
            this.btnBancos,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(821, 149);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.ActAsDropDown = true;
            this.barButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem1.Caption = "Mantenimiento";
            this.barButtonItem1.DropDownControl = this.Mantenimiento;
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // Mantenimiento
            // 
            this.Mantenimiento.ItemLinks.Add(this.btnTiposDeCuentas);
            this.Mantenimiento.ItemLinks.Add(this.btnCrearCuentas);
            this.Mantenimiento.ItemLinks.Add(this.btnEstatus);
            this.Mantenimiento.ItemLinks.Add(this.btnBancos);
            this.Mantenimiento.Name = "Mantenimiento";
            this.Mantenimiento.Ribbon = this.ribbonControl1;
            // 
            // btnTiposDeCuentas
            // 
            this.btnTiposDeCuentas.Caption = "Tipos De Cuentas";
            this.btnTiposDeCuentas.Id = 4;
            this.btnTiposDeCuentas.Name = "btnTiposDeCuentas";
            this.btnTiposDeCuentas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnCrearCuentas
            // 
            this.btnCrearCuentas.Caption = "Cuentas";
            this.btnCrearCuentas.Id = 5;
            this.btnCrearCuentas.Name = "btnCrearCuentas";
            // 
            // btnEstatus
            // 
            this.btnEstatus.Caption = "Estatus";
            this.btnEstatus.Id = 6;
            this.btnEstatus.Name = "btnEstatus";
            // 
            // btnBancos
            // 
            this.btnBancos.Caption = "Bancos";
            this.btnBancos.Id = 4;
            this.btnBancos.Name = "btnBancos";
            this.btnBancos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBancos_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 2;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.ActAsDropDown = true;
            this.barButtonItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem2.Caption = "Archivo";
            this.barButtonItem2.DropDownControl = this.Archivo;
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // Archivo
            // 
            this.Archivo.ItemLinks.Add(this.btnAperturarCuenta);
            this.Archivo.ItemLinks.Add(this.btnTransferencias);
            this.Archivo.ItemLinks.Add(this.btnSalir);
            this.Archivo.ItemLinks.Add(this.barButtonItem3);
            this.Archivo.Name = "Archivo";
            this.Archivo.Ribbon = this.ribbonControl1;
            // 
            // btnAperturarCuenta
            // 
            this.btnAperturarCuenta.Caption = "Aperturar Cuenta";
            this.btnAperturarCuenta.Id = 7;
            this.btnAperturarCuenta.Name = "btnAperturarCuenta";
            this.btnAperturarCuenta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAperturarCuenta_ItemClick);
            // 
            // btnTransferencias
            // 
            this.btnTransferencias.Caption = "Transferencias";
            this.btnTransferencias.Id = 8;
            this.btnTransferencias.Name = "btnTransferencias";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 9;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Autorizaciones";
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.ActAsDropDown = true;
            this.barButtonItem9.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem9.Caption = "Consultas";
            this.barButtonItem9.DropDownControl = this.Consultas;
            this.barButtonItem9.Id = 1;
            this.barButtonItem9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // Consultas
            // 
            this.Consultas.Name = "Consultas";
            this.Consultas.Ribbon = this.ribbonControl1;
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Reportes";
            this.barButtonItem10.Id = 2;
            this.barButtonItem10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.Image")));
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 3;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Autorizacion Transaciones";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.BackColor = System.Drawing.Color.Blue;
            this.ribbonPage1.Appearance.Options.UseBackColor = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageUri.Uri = "Forward";
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Menu Principal";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.barButtonItem4);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl1;
            // 
            // FrmDeposito
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 502);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.IsMdiContainer = true;
            this.Name = "FrmDeposito";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Modulo Deposito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Archivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.PopupMenu Mantenimiento;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.PopupMenu Archivo;
        private DevExpress.XtraBars.BarButtonItem btnTiposDeCuentas;
        private DevExpress.XtraBars.BarButtonItem btnCrearCuentas;
        private DevExpress.XtraBars.BarButtonItem btnEstatus;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btnAperturarCuenta;
        private DevExpress.XtraBars.BarButtonItem btnTransferencias;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.PopupMenu Consultas;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnBancos;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
    }
}

