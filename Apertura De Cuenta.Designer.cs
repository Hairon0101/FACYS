namespace FacSys
{
    partial class Apertura_De_Cuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apertura_De_Cuenta));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtidcuenta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCliente = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtOficna = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreCliente = new DevExpress.XtraEditors.TextEdit();
            this.txtTipoCuenta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMontoMinimoApertura = new DevExpress.XtraEditors.TextEdit();
            this.cmbTiposCuentas = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmboficina = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btncancelar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkPermitirSobregiros = new DevExpress.XtraEditors.CheckEdit();
            this.chkGanaInteres = new DevExpress.XtraEditors.CheckEdit();
            this.btnApertura = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMontoEfectivo = new DevExpress.XtraEditors.TextEdit();
            this.txtfecha = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtidcuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOficna.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoMinimoApertura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTiposCuentas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmboficina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkPermitirSobregiros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGanaInteres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoEfectivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfecha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 96);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tipo De Cuenta";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(58, 67);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(51, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Id_Cuenta";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(76, 155);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(33, 13);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Oficina";
            // 
            // txtidcuenta
            // 
            this.txtidcuenta.Location = new System.Drawing.Point(124, 64);
            this.txtidcuenta.Name = "txtidcuenta";
            this.txtidcuenta.Properties.ReadOnly = true;
            this.txtidcuenta.Size = new System.Drawing.Size(100, 20);
            this.txtidcuenta.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(76, 127);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(124, 122);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(31, 183);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Fecha_Apertura";
            // 
            // txtOficna
            // 
            this.txtOficna.Location = new System.Drawing.Point(230, 150);
            this.txtOficna.Name = "txtOficna";
            this.txtOficna.Properties.ReadOnly = true;
            this.txtOficna.Size = new System.Drawing.Size(238, 20);
            this.txtOficna.TabIndex = 1;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(230, 122);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Properties.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(238, 20);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // txtTipoCuenta
            // 
            this.txtTipoCuenta.Location = new System.Drawing.Point(230, 93);
            this.txtTipoCuenta.Name = "txtTipoCuenta";
            this.txtTipoCuenta.Properties.ReadOnly = true;
            this.txtTipoCuenta.Size = new System.Drawing.Size(238, 20);
            this.txtTipoCuenta.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(44, 212);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 26);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Monto Minimo \r\nApertura";
            // 
            // txtMontoMinimoApertura
            // 
            this.txtMontoMinimoApertura.Location = new System.Drawing.Point(124, 209);
            this.txtMontoMinimoApertura.Name = "txtMontoMinimoApertura";
            this.txtMontoMinimoApertura.Size = new System.Drawing.Size(100, 20);
            this.txtMontoMinimoApertura.TabIndex = 4;
            // 
            // cmbTiposCuentas
            // 
            this.cmbTiposCuentas.Enabled = false;
            this.cmbTiposCuentas.Location = new System.Drawing.Point(124, 93);
            this.cmbTiposCuentas.Name = "cmbTiposCuentas";
            this.cmbTiposCuentas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTiposCuentas.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbTiposCuentas.Size = new System.Drawing.Size(100, 20);
            this.cmbTiposCuentas.TabIndex = 0;
            this.cmbTiposCuentas.SelectedIndexChanged += new System.EventHandler(this.cmbTiposCuentas_SelectedIndexChanged);
            // 
            // cmboficina
            // 
            this.cmboficina.Enabled = false;
            this.cmboficina.Location = new System.Drawing.Point(124, 151);
            this.cmboficina.Name = "cmboficina";
            this.cmboficina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmboficina.Size = new System.Drawing.Size(100, 20);
            this.cmboficina.TabIndex = 2;
            this.cmboficina.SelectedIndexChanged += new System.EventHandler(this.cmboficina_SelectedIndexChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Appearance.Options.UseFont = true;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(12, 300);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(114, 41);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Appearance.Options.UseFont = true;
            this.btncancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.ImageOptions.Image")));
            this.btncancelar.Location = new System.Drawing.Point(270, 300);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(106, 41);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.chkPermitirSobregiros);
            this.groupControl1.Controls.Add(this.chkGanaInteres);
            this.groupControl1.Controls.Add(this.cmboficina);
            this.groupControl1.Controls.Add(this.cmbTiposCuentas);
            this.groupControl1.Controls.Add(this.txtMontoEfectivo);
            this.groupControl1.Controls.Add(this.txtMontoMinimoApertura);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtTipoCuenta);
            this.groupControl1.Controls.Add(this.txtNombreCliente);
            this.groupControl1.Controls.Add(this.txtOficna);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtfecha);
            this.groupControl1.Controls.Add(this.txtCliente);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtidcuenta);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 23);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(487, 271);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Aperturar Cuenta De Ahorro";
            // 
            // chkPermitirSobregiros
            // 
            this.chkPermitirSobregiros.Location = new System.Drawing.Point(355, 181);
            this.chkPermitirSobregiros.Name = "chkPermitirSobregiros";
            this.chkPermitirSobregiros.Properties.Caption = "Permitir Sobregiros";
            this.chkPermitirSobregiros.Size = new System.Drawing.Size(113, 19);
            this.chkPermitirSobregiros.TabIndex = 5;
            // 
            // chkGanaInteres
            // 
            this.chkGanaInteres.Location = new System.Drawing.Point(230, 180);
            this.chkGanaInteres.Name = "chkGanaInteres";
            this.chkGanaInteres.Properties.Caption = "Gana Interes";
            this.chkGanaInteres.Size = new System.Drawing.Size(98, 19);
            this.chkGanaInteres.TabIndex = 5;
            // 
            // btnApertura
            // 
            this.btnApertura.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApertura.Appearance.Options.UseFont = true;
            this.btnApertura.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnApertura.Location = new System.Drawing.Point(145, 300);
            this.btnApertura.Name = "btnApertura";
            this.btnApertura.Size = new System.Drawing.Size(106, 41);
            this.btnApertura.TabIndex = 1;
            this.btnApertura.Text = "Aperturar";
            this.btnApertura.Click += new System.EventHandler(this.btnApertura_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Appearance.Options.UseFont = true;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(393, 300);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 41);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(33, 241);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Monto Apertura";
            // 
            // txtMontoEfectivo
            // 
            this.txtMontoEfectivo.Location = new System.Drawing.Point(124, 238);
            this.txtMontoEfectivo.Name = "txtMontoEfectivo";
            this.txtMontoEfectivo.Size = new System.Drawing.Size(100, 20);
            this.txtMontoEfectivo.TabIndex = 4;
            // 
            // txtfecha
            // 
            this.txtfecha.Enabled = false;
            this.txtfecha.Location = new System.Drawing.Point(124, 179);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 1;
            this.txtfecha.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // Apertura_De_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 354);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnApertura);
            this.Name = "Apertura_De_Cuenta";
            this.Text = "Apertura_De_Cuenta";
            this.Load += new System.EventHandler(this.Apertura_De_Cuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtidcuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOficna.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoMinimoApertura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTiposCuentas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmboficina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkPermitirSobregiros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGanaInteres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoEfectivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfecha.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtidcuenta;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCliente;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtOficna;
        private DevExpress.XtraEditors.TextEdit txtNombreCliente;
        private DevExpress.XtraEditors.TextEdit txtTipoCuenta;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtMontoMinimoApertura;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTiposCuentas;
        private DevExpress.XtraEditors.ComboBoxEdit cmboficina;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraEditors.SimpleButton btncancelar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chkPermitirSobregiros;
        private DevExpress.XtraEditors.CheckEdit chkGanaInteres;
        private DevExpress.XtraEditors.SimpleButton btnApertura;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.TextEdit txtMontoEfectivo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtfecha;
    }
}