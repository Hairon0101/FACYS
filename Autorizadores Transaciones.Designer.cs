namespace FacSys
{
    partial class Autorizadores_Transaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorizadores_Transaciones));
            this.txtusuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbSucursal = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMontoDesde = new DevExpress.XtraEditors.TextEdit();
            this.txtMontoHasta = new DevExpress.XtraEditors.TextEdit();
            this.chkPermitirTransito = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardarAutorizaciones = new DevExpress.XtraEditors.SimpleButton();
            this.btnBorrarAutorizaciones = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtusuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPermitirTransito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(99, 50);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(137, 20);
            this.txtusuario.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Usuario";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(41, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Sucursal";
            this.labelControl2.Click += new System.EventHandler(this.s);
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Location = new System.Drawing.Point(99, 76);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSucursal.Size = new System.Drawing.Size(137, 20);
            this.cmbSucursal.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(51, 154);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Desde";
            this.labelControl4.Click += new System.EventHandler(this.s);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(53, 180);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Hasta";
            this.labelControl5.Click += new System.EventHandler(this.s);
            // 
            // txtMontoDesde
            // 
            this.txtMontoDesde.Location = new System.Drawing.Point(99, 151);
            this.txtMontoDesde.Name = "txtMontoDesde";
            this.txtMontoDesde.Size = new System.Drawing.Size(137, 20);
            this.txtMontoDesde.TabIndex = 0;
            // 
            // txtMontoHasta
            // 
            this.txtMontoHasta.Location = new System.Drawing.Point(99, 177);
            this.txtMontoHasta.Name = "txtMontoHasta";
            this.txtMontoHasta.Size = new System.Drawing.Size(137, 20);
            this.txtMontoHasta.TabIndex = 0;
            // 
            // chkPermitirTransito
            // 
            this.chkPermitirTransito.Location = new System.Drawing.Point(99, 216);
            this.chkPermitirTransito.Name = "chkPermitirTransito";
            this.chkPermitirTransito.Properties.Caption = "Permitir Ck  En Transito";
            this.chkPermitirTransito.Size = new System.Drawing.Size(137, 19);
            this.chkPermitirTransito.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.ImageUri.Uri = "Apply";
            this.groupControl1.Controls.Add(this.btnSalir);
            this.groupControl1.Controls.Add(this.btnBorrarAutorizaciones);
            this.groupControl1.Controls.Add(this.btnGuardarAutorizaciones);
            this.groupControl1.Controls.Add(this.chkPermitirTransito);
            this.groupControl1.Controls.Add(this.txtMontoHasta);
            this.groupControl1.Controls.Add(this.txtusuario);
            this.groupControl1.Controls.Add(this.cmbSucursal);
            this.groupControl1.Controls.Add(this.txtMontoDesde);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(415, 248);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Autorizaciones Retiros De Ahorro";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(137, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Monto";
            this.labelControl3.Click += new System.EventHandler(this.s);
            // 
            // btnGuardarAutorizaciones
            // 
            this.btnGuardarAutorizaciones.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnGuardarAutorizaciones.Location = new System.Drawing.Point(283, 50);
            this.btnGuardarAutorizaciones.Name = "btnGuardarAutorizaciones";
            this.btnGuardarAutorizaciones.Size = new System.Drawing.Size(88, 37);
            this.btnGuardarAutorizaciones.TabIndex = 4;
            this.btnGuardarAutorizaciones.Text = "Guardar";
            // 
            // btnBorrarAutorizaciones
            // 
            this.btnBorrarAutorizaciones.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnBorrarAutorizaciones.Location = new System.Drawing.Point(283, 96);
            this.btnBorrarAutorizaciones.Name = "btnBorrarAutorizaciones";
            this.btnBorrarAutorizaciones.Size = new System.Drawing.Size(88, 37);
            this.btnBorrarAutorizaciones.TabIndex = 4;
            this.btnBorrarAutorizaciones.Text = "Borrar";
            // 
            // btnSalir
            // 
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(283, 142);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 37);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            // 
            // Autorizadores_Transaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 352);
            this.Controls.Add(this.groupControl1);
            this.Name = "Autorizadores_Transaciones";
            this.Text = "Autorizadores_Transaciones";
            ((System.ComponentModel.ISupportInitialize)(this.txtusuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPermitirTransito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtusuario;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSucursal;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMontoDesde;
        private DevExpress.XtraEditors.TextEdit txtMontoHasta;
        private DevExpress.XtraEditors.CheckEdit chkPermitirTransito;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.SimpleButton btnBorrarAutorizaciones;
        private DevExpress.XtraEditors.SimpleButton btnGuardarAutorizaciones;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}