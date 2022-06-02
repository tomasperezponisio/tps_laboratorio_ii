using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Exceptions;

namespace Formulario
{
    public partial class frmInicio : Form
    {
        private Club club;
        bool flagTipo = true;
        public frmInicio()
        {
            InitializeComponent();
            this.club = new Club("Club Armenio");
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {

            Socio s1 = new Socio("Tomas", "Perez", 31443243, new DateTime(1985, 02, 24), Socio.EActividad.Natacion, Socio.ECategoria.Mayor);
            Socio s2 = new Socio("Julia", "Baliña", 33103475, new DateTime(1987, 07, 05), Socio.EActividad.Voley, Socio.ECategoria.Adulto);
            Socio s3 = new Socio("Franco", "Messina", 40123456, new DateTime(1990, 01, 02), Socio.EActividad.Futbol, Socio.ECategoria.Joven);

            Empleado e1 = new Empleado("Renzo", "Orpelli", 45001001, new DateTime(2000, 12, 24), Empleado.EArea.Mantenimiento, Empleado.ETurno.Tarde);
            Empleado e2 = new Empleado("Pablo", "Hernandez", 38569752, new DateTime(1989, 10, 12), Empleado.EArea.Administrativo, Empleado.ETurno.Mañana);

            bool ss1 = (club + s1);
            bool ss2 = (club + s2);
            bool ss3 = (club + s3);

            bool ee1 = (club + e1);
            bool ee2 = (club + e2);

            this.lblEnum1.Text = "Categoria";
            this.cmbEnum1.DataSource = Enum.GetValues(typeof(Socio.ECategoria));

            this.lblEnum2.Text = "Actividad";
            this.cmbEnum2.DataSource = Enum.GetValues(typeof(Socio.EActividad));

            this.ActualizaListaSocios();
            this.LimpiarForm();
        }

        #region Botones y eventos del form
        private void rbSocio_CheckedChanged(object sender, EventArgs e)                   // ACA ES PARA SOCIOS
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    this.flagTipo = true;

                    this.lblEnum1.Text = "Categoria";
                    this.cmbEnum1.DataSource = Enum.GetValues(typeof(Socio.ECategoria));

                    this.lblEnum2.Text = "Actividad";
                    this.cmbEnum2.DataSource = Enum.GetValues(typeof(Socio.EActividad));

                    this.ActualizaListaSocios();
                    this.LimpiarForm();
                }
            }
        }
        private void rbEmpleado_CheckedChanged(object sender, EventArgs e)               // ACA ES PARA EMPLEADOS
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    this.flagTipo = false;

                    this.lblEnum1.Text = "Area";
                    this.cmbEnum1.DataSource = Enum.GetValues(typeof(Empleado.EArea));

                    this.lblEnum2.Text = "Turno";
                    this.cmbEnum2.DataSource = Enum.GetValues(typeof(Empleado.ETurno));

                    this.ActualizaListaEmpleados();
                    this.LimpiarForm();
                }
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidarCampos();

                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                int dni = int.Parse(this.txtDni.Text);
                DateTime fechaNacimiento = this.dtpFechaNacimiento.Value;

                if (this.flagTipo)
                {
                    Socio.ECategoria categoria = (Socio.ECategoria)this.cmbEnum1.SelectedItem;
                    Socio.EActividad actividad = (Socio.EActividad)this.cmbEnum2.SelectedItem;

                    Socio socio = new Socio(nombre, apellido, dni, fechaNacimiento, actividad, categoria);
                    string mensaje = string.Empty;

                    if (this.IngresarSocio(this.club, socio))
                    {
                        MessageBox.Show("Socio agreado con éxito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.ActualizaListaSocios();
                }
                else
                {
                    Empleado.EArea area = (Empleado.EArea)this.cmbEnum1.SelectedItem;
                    Empleado.ETurno turno = (Empleado.ETurno)this.cmbEnum2.SelectedItem;

                    Empleado empleado = new Empleado(nombre, apellido, dni, fechaNacimiento, area, turno);
                    string mensaje = string.Empty;

                    if (this.IngresarEmpleado(this.club, empleado))
                    {
                        MessageBox.Show("Empleado agreado con éxito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.ActualizaListaEmpleados();
                }
            }
            catch (DniInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CampoVacioException ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IngresoAlClubException ex)
            {
                MessageBox.Show(ex.Message, "Error al ingresar al club", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            this.LimpiarForm();
        }
        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Socio socio;
            Empleado empleado;
            if (this.lstPersonas.SelectedIndex != -1)
            {
                this.btnModificar.Enabled = true;
                this.btnCargar.Enabled = false;

                if (this.flagTipo)
                {
                    socio = (Socio)this.lstPersonas.SelectedItem;
                    this.TraerDatosSocio(socio);
                }
                else
                {
                    empleado = (Empleado)this.lstPersonas.SelectedItem;
                    this.TraerDatosEmpleado(empleado);
                }
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Socio socio;
            Empleado empleado;
            if (this.lstPersonas.SelectedIndex != -1)
            {
                this.btnModificar.Enabled = true;
                this.btnCargar.Enabled = false;
                try 
                {
                    if (this.flagTipo)
                    {
                        socio = (Socio)this.lstPersonas.SelectedItem;

                        this.ValidarCampos();

                        socio.Nombre = this.txtNombre.Text;
                        socio.Apellido = this.txtApellido.Text;
                        socio.Dni = int.Parse(this.txtDni.Text);
                        socio.FechaNacimiento = this.dtpFechaNacimiento.Value;
                        socio.Categoria = (Socio.ECategoria)this.cmbEnum1.SelectedItem;
                        socio.Actividad = (Socio.EActividad)this.cmbEnum2.SelectedItem;

                        this.ActualizaListaSocios();
                    }
                    else
                    {
                        empleado = (Empleado)this.lstPersonas.SelectedItem;

                        this.ValidarCampos();

                        empleado.Nombre = this.txtNombre.Text;
                        empleado.Apellido = this.txtApellido.Text;
                        empleado.Dni = int.Parse(this.txtDni.Text);
                        empleado.FechaNacimiento = this.dtpFechaNacimiento.Value;
                        empleado.Area = (Empleado.EArea)this.cmbEnum1.SelectedItem;
                        empleado.Turno = (Empleado.ETurno)this.cmbEnum2.SelectedItem;

                        this.ActualizaListaEmpleados();
                    }
                }
                catch (DniInvalidoException ex)
                {
                    MessageBox.Show(ex.Message, "Error al modificar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (CampoVacioException ex)
                {
                    MessageBox.Show(ex.Message, "Error al modificar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al modificar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Socio socio;
            Empleado empleado;
            if (this.lstPersonas.SelectedIndex != -1)
            {
                this.btnModificar.Enabled = true;
                this.btnCargar.Enabled = false;

                if (this.flagTipo)
                {
                    socio = (Socio)this.lstPersonas.SelectedItem;
                    MessageBox.Show(this.EliminarSocio(this.club, socio), "Eliminar socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ActualizaListaSocios();
                }
                else
                {
                    empleado = (Empleado)this.lstPersonas.SelectedItem;
                    MessageBox.Show(this.EliminarEmpleado(this.club, empleado), "Eliminar empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ActualizaListaEmpleados();
                }
            }
        } 
        #endregion

        #region Metodos
        private void ActualizaListaSocios()
        {
            this.lstPersonas.DataSource = null;
            this.lstPersonas.DataSource = club.ListaSocios;
        }
        private void ActualizaListaEmpleados()
        {
            this.lstPersonas.DataSource = null;
            this.lstPersonas.DataSource = club.ListaEmpleados;
        }
        private void LimpiarForm()
        {
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtDni.Text = string.Empty;
            this.dtpFechaNacimiento.Value = DateTime.Now;
            this.lstPersonas.SelectedIndex = -1;
            this.btnModificar.Enabled = false;
            this.btnCargar.Enabled = true;
        }
        private void TraerDatosSocio(Socio socio)
        {
            this.txtNombre.Text = socio.Nombre;
            this.txtApellido.Text = socio.Apellido;
            this.txtDni.Text = socio.Dni.ToString();
            this.dtpFechaNacimiento.Value = socio.FechaNacimiento;
            //                                                                HACER PARA ACTIVIDAD Y CATEGORIA
        }
        private void TraerDatosEmpleado(Empleado empleado)
        {
            this.txtNombre.Text = empleado.Nombre;
            this.txtApellido.Text = empleado.Apellido;
            this.txtDni.Text = empleado.Dni.ToString();
            this.dtpFechaNacimiento.Value = empleado.FechaNacimiento;
            //                                                                HACER PARA ACTIVIDAD Y CATEGORIA
        }

        private bool ValidarCampos()
        {
            if (this.txtNombre.Text == string.Empty || this.txtApellido.Text == string.Empty || this.txtDni.Text == string.Empty)
            {
                throw new CampoVacioException("Todos los campos deben estar completos");
            }
            else if (!int.TryParse(this.txtDni.Text, out int dni))
            {
                throw new DniInvalidoException("El DNI debe ser un número");
            }
            else if (int.Parse(this.txtDni.Text) <= 0 || int.Parse(this.txtDni.Text) >= 99999999)
            {
                throw new DniInvalidoException("El DNI debe ser un número entre 0 y 99.999.999");
            }
            else if (this.dtpFechaNacimiento.Value >= DateTime.Now)
            {
                throw new FechaNacimientoInvalidaException("La Fecha de nacimiento debe ser menor a la fecha actual");
            }
            return true;
        }

        private bool IngresarSocio(Club club, Socio socio)
        {
            if (!(this.club != socio && club + socio))
            {
                throw new IngresoAlClubException("No se pudo agregar el socio");
            }
            return true;
        }
        private bool IngresarEmpleado(Club club, Empleado empleado)
        {
            if (!(this.club != empleado && club + empleado))
            {
                throw new IngresoAlClubException("No se pudo agregar el empleado");
            }
            return true;
        }

        private string EliminarSocio(Club club, Socio socio)
        {
            string mensaje = "El socio no se ha encontrado";
            if (club - socio)
            {
                mensaje = "Socio eliminado con exito";
            }
            return mensaje;
        }
        private string EliminarEmpleado(Club club, Empleado empleado)
        {
            string mensaje = "El empleado no se ha encontrado";
            if (club - empleado)
            {
                mensaje = "empleado eliminado con exito";
            }
            return mensaje;
        } 
        #endregion

    }
}
