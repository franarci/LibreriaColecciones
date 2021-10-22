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
    public partial class frmPublicadores : Form
    {
        public frmPublicadores()
        {
            InitializeComponent();
        }

        private void frmPublicadores_Load(object sender, EventArgs e)
        {
            mostrarPublicadores();
        }

        private void mostrarPublicadores()
        {
            grdPublicadores.DataSource = AdminPublicadores.Listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Publicador publicador = new Publicador(Convert.ToInt32(txtId.Text), txtApellido.Text, txtNombre.Text, Convert.ToDateTime(txtFechaNac.Text), txtCiudad.Text);
            AdminPublicadores.Insertar(publicador);
            actualizarGrilla();
        }

        private void actualizarGrilla()
        {
            grdPublicadores.DataSource = null;
            grdPublicadores.DataSource = AdminPublicadores.Listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AdminPublicadores.Eliminar(Convert.ToInt32(Interaction.InputBox("Ingrese un id")));
            actualizarGrilla();
        }
    }
}
