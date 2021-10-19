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
           
        }
    }
}
