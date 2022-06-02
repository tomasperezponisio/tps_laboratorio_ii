namespace Formulario
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEnum1 = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.cmbEnum1 = new System.Windows.Forms.ComboBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEnum2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbEnum2 = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lstPersonas = new System.Windows.Forms.ListBox();
            this.grbTipo = new System.Windows.Forms.GroupBox();
            this.rbEmpleado = new System.Windows.Forms.RadioButton();
            this.rbSocio = new System.Windows.Forms.RadioButton();
            this.btnLimpiarForm = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Formulario.Properties.Resources.escudo_de_armenia;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 122);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(166, 180);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(217, 23);
            this.dtpFechaNacimiento.TabIndex = 21;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(166, 129);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(217, 23);
            this.txtDni.TabIndex = 20;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(12, 257);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(139, 23);
            this.btnCargar.TabIndex = 23;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(166, 78);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(217, 23);
            this.txtApellido.TabIndex = 19;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(166, 162);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(117, 15);
            this.lblFechaNacimiento.TabIndex = 17;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblEnum1
            // 
            this.lblEnum1.AutoSize = true;
            this.lblEnum1.Location = new System.Drawing.Point(166, 215);
            this.lblEnum1.Name = "lblEnum1";
            this.lblEnum1.Size = new System.Drawing.Size(58, 15);
            this.lblEnum1.TabIndex = 24;
            this.lblEnum1.Text = "Categoria";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(166, 111);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(27, 15);
            this.lblDni.TabIndex = 16;
            this.lblDni.Text = "DNI";
            // 
            // cmbEnum1
            // 
            this.cmbEnum1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnum1.FormattingEnabled = true;
            this.cmbEnum1.Items.AddRange(new object[] {
            "Joven",
            "Adulto",
            "Mayor"});
            this.cmbEnum1.Location = new System.Drawing.Point(166, 233);
            this.cmbEnum1.Name = "cmbEnum1";
            this.cmbEnum1.Size = new System.Drawing.Size(217, 23);
            this.cmbEnum1.TabIndex = 22;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(166, 60);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 15;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEnum2
            // 
            this.lblEnum2.AutoSize = true;
            this.lblEnum2.Location = new System.Drawing.Point(166, 270);
            this.lblEnum2.Name = "lblEnum2";
            this.lblEnum2.Size = new System.Drawing.Size(57, 15);
            this.lblEnum2.TabIndex = 26;
            this.lblEnum2.Text = "Actividad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(166, 11);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // cmbEnum2
            // 
            this.cmbEnum2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnum2.FormattingEnabled = true;
            this.cmbEnum2.Items.AddRange(new object[] {
            "Basquet",
            "Futbol",
            "Natacion",
            "Voley"});
            this.cmbEnum2.Location = new System.Drawing.Point(166, 288);
            this.cmbEnum2.Name = "cmbEnum2";
            this.cmbEnum2.Size = new System.Drawing.Size(217, 23);
            this.cmbEnum2.TabIndex = 27;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(166, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 23);
            this.txtNombre.TabIndex = 18;
            // 
            // lstPersonas
            // 
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.HorizontalScrollbar = true;
            this.lstPersonas.ItemHeight = 15;
            this.lstPersonas.Location = new System.Drawing.Point(398, 29);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(943, 319);
            this.lstPersonas.TabIndex = 28;
            this.lstPersonas.SelectedIndexChanged += new System.EventHandler(this.lstPersonas_SelectedIndexChanged);
            // 
            // grbTipo
            // 
            this.grbTipo.Controls.Add(this.rbEmpleado);
            this.grbTipo.Controls.Add(this.rbSocio);
            this.grbTipo.Location = new System.Drawing.Point(12, 140);
            this.grbTipo.Name = "grbTipo";
            this.grbTipo.Size = new System.Drawing.Size(139, 79);
            this.grbTipo.TabIndex = 29;
            this.grbTipo.TabStop = false;
            this.grbTipo.Text = "Tipo";
            // 
            // rbEmpleado
            // 
            this.rbEmpleado.AutoSize = true;
            this.rbEmpleado.Location = new System.Drawing.Point(15, 47);
            this.rbEmpleado.Name = "rbEmpleado";
            this.rbEmpleado.Size = new System.Drawing.Size(78, 19);
            this.rbEmpleado.TabIndex = 1;
            this.rbEmpleado.Text = "Empleado";
            this.rbEmpleado.UseVisualStyleBackColor = true;
            this.rbEmpleado.CheckedChanged += new System.EventHandler(this.rbEmpleado_CheckedChanged);
            // 
            // rbSocio
            // 
            this.rbSocio.AutoSize = true;
            this.rbSocio.Checked = true;
            this.rbSocio.Location = new System.Drawing.Point(15, 22);
            this.rbSocio.Name = "rbSocio";
            this.rbSocio.Size = new System.Drawing.Size(54, 19);
            this.rbSocio.TabIndex = 0;
            this.rbSocio.TabStop = true;
            this.rbSocio.Text = "Socio";
            this.rbSocio.UseVisualStyleBackColor = true;
            this.rbSocio.CheckedChanged += new System.EventHandler(this.rbSocio_CheckedChanged);
            // 
            // btnLimpiarForm
            // 
            this.btnLimpiarForm.Location = new System.Drawing.Point(12, 226);
            this.btnLimpiarForm.Name = "btnLimpiarForm";
            this.btnLimpiarForm.Size = new System.Drawing.Size(139, 23);
            this.btnLimpiarForm.TabIndex = 30;
            this.btnLimpiarForm.Text = "Limpiar Form";
            this.btnLimpiarForm.UseVisualStyleBackColor = true;
            this.btnLimpiarForm.Click += new System.EventHandler(this.btnLimpiarForm_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 288);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(139, 23);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 320);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(139, 23);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1353, 364);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnLimpiarForm);
            this.Controls.Add(this.grbTipo);
            this.Controls.Add(this.lstPersonas);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbEnum2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblEnum2);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.cmbEnum1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblEnum1);
            this.Controls.Add(this.lblFechaNacimiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UGAB";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbTipo.ResumeLayout(false);
            this.grbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblEnum1;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.ComboBox cmbEnum1;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEnum2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbEnum2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox lstPersonas;
        private System.Windows.Forms.GroupBox grbTipo;
        private System.Windows.Forms.RadioButton rbEmpleado;
        private System.Windows.Forms.RadioButton rbSocio;
        private System.Windows.Forms.Button btnLimpiarForm;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}
