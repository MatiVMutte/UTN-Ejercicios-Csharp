namespace ClaseSabado
{
    public partial class FrmPrincipal : Form
    {
        List<Empleado> miLista;

        public FrmPrincipal() {
            InitializeComponent();
            miLista = new List<Empleado>();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e) {
            this.IsMdiContainer = true;
        }

        private void cargarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmEmpleado frm_Empleado = new FrmEmpleado();
            // frm_Empleado.MdiParent = this; // Contenido dentro del principal
            if (frm_Empleado.ShowDialog() == DialogResult.OK) { // Formulario modal - Pone en foco a ese formulario. Hasta que termine ese Form | Devuelve un DialogResult
                miLista.Add(frm_Empleado.MiEmpleado);
            }

        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmGestion frm_Gestion = new FrmGestion(miLista);
            frm_Gestion.MdiParent = this;
            frm_Gestion.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private DialogResult PreguntarSalida() {
            return MessageBox.Show("¿Estas seguro que queres salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
            // MessageBox.Show(sender.ToString()); // El sender es el Control/Componente que se esta ejecutando
            if (PreguntarSalida() == DialogResult.No) {
                e.Cancel = true;
            }
        }

        /*FrmEmpleado frm_Empleado = new FrmEmpleado();
        frm_Empleado.TopLevel = false;
        pnlForm.Controls.Add(frm_Empleado);
        frm_Empleado.Visible = true;*/
    }
}