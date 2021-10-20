using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Models;
using Microsoft.VisualBasic;

namespace WindowsList
{
    public partial class Form1 : Form
    {
        List<Autor> autores = new List<Autor>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            autores.Add(new Autor(Convert.ToInt32(txtId.Text), txtApellido.Text, txtNombre.Text, Convert.ToDateTime(txtFechaNac.Text), txtCiudad.Text, txtNacionalidad.Text));

            actualizarGrilla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            autores.AddRange( new List<Autor> {
                new Autor(0, "Martinez","Pedro", new DateTime(1990,04,04), "CABA", "Argentina"),
                new Autor(1, "King", "Stephen", new DateTime(1947,09,21),"Portland", "Estados Unidos")
            });

            grdAutores.DataSource = autores;
            
        }

        private void btnTraerPorCiudad_Click(object sender, EventArgs e)
        {
            autores = AdminAutores.listarPorCiudad(autores, Interaction.InputBox("Ingrese una ciudad"));
            actualizarGrilla();
        }

        public void actualizarGrilla()
        {
            grdAutores.DataSource = null;
            grdAutores.DataSource = autores;
        }
    }
}
