using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseSabado
{
    public partial class FrmEmpleado : Form
    {
        Empleado miEmpleado;
        String path;

        public Empleado MiEmpleado { get => miEmpleado; }


        public FrmEmpleado() {
            InitializeComponent();
        }

        public FrmEmpleado(Empleado empl) : this() {
            miEmpleado = empl;
            txtNombre.Text = empl.Nombre;
            txtSueldo.Text = empl.Sueldo.ToString();
            if (empl.Path_imagen is not null) {
                pictureBox1.Image = Image.FromFile(empl.Path_imagen);
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e) {
            Empleado empleadoModificado;
            if (path is null) {
                // miEmpleado = new Empleado(txtNombre.Text, float.Parse(txtSueldo.Text), path);
                path = miEmpleado.Path_imagen;
            }
           /* else {
                empleadoModificado = new Empleado(txtNombre.Text, float.Parse(txtSueldo.Text), miEmpleado.Path_imagen);
                miEmpleado = empleadoModificado;
            }*/

            miEmpleado = new Empleado(txtNombre.Text, float.Parse(txtSueldo.Text), path);

            this.DialogResult = DialogResult.OK; // 
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel; // 
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e) {
            if (txtNombre.Text.Length == 0) {
                errorProvider1.SetError(txtNombre, "No hay nada ingrsado");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e) {
            if (txtNombre.Text.Length != 0) {
                errorProvider1.Clear();
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e) {

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK) {
                path = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(path);
            }
        }
    }
}
