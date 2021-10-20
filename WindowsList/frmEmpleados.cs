using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Models.Admin;
using Entidades.Models;
using Microsoft.VisualBasic;

namespace WindowsList
{
    public partial class frmEmpleados : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            precarga();
        }

        private void precarga()
        {
            empleados.AddRange(new List<Empleado> {
                 new Empleado(0, "Martinez","Pedro", new DateTime(1990,04,04), "CABA", "Argentina"),
                 new Empleado(1, "Fernandez", "Carla", new DateTime(1947,09,21),"La Plata", "Argentina"),
                 new Empleado(2, "Santos", "Gustavo", new DateTime(1970,06,13),"Ezeiza", "Argentina")
            });

            grdEmpleados.DataSource = empleados;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            empleados.Add(new Empleado(Convert.ToInt32(txtId.Text), txtApellido.Text, txtNombre.Text, Convert.ToDateTime(txtFechaNac.Text), txtCiudad.Text, txtNacionalidad.Text));

            actualizarGrilla();
        }

        public void actualizarGrilla()
        {
            grdEmpleados.DataSource = null;
            grdEmpleados.DataSource = empleados;
        }

        private void btnTraerPorId_Click(object sender, EventArgs e)
        {
            Empleado empleado = AdminEmpleados.buscarPorId(empleados, Convert.ToInt32(Interaction.InputBox("Ingrese un id")));
            MessageBox.Show(empleado != null ? "El empleado es: "+ empleado.Nombre + " " +empleado.Apellido : "No se encontro ningun empleado con ese id");
        }
    }
}
