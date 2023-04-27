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
    public partial class FrmGestion : Form
    {
        List<Empleado> listaFormulario;

        public FrmGestion(List<Empleado> lista) {
            this.listaFormulario = lista;
            InitializeComponent();
        }

        private void MostrarLista() {
            listBox1.Items.Clear();
            foreach (Empleado emp in listaFormulario) {
                listBox1.Items.Add(emp);
            }
        }

        private void FrmGestion_Load(object sender, EventArgs e) {
            MostrarLista();
        }

        private void btnBorrar_Click(object sender, EventArgs e) {
            int index;
            index = listBox1.SelectedIndex;
            if (index != -1) {
                listaFormulario.RemoveAt(index); // Borra recibiendo el Indice
                MostrarLista();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            FrmEmpleado frm_Empleado;
            Empleado empleadoModificar;
            int index;
            index = listBox1.SelectedIndex;
            if (index != -1) {
                // empleadoModificar = listaFormulario[index]; // Devuelve el objeto del indice especificado
                empleadoModificar = listaFormulario.ElementAt(index); // Devuelve el objeto del indice especificado

                // frm_Empleado = new FrmEmpleado(empleadoModificar);

                frm_Empleado = new FrmEmpleado(empleadoModificar);

                if (frm_Empleado.ShowDialog() == DialogResult.OK) {
                    listaFormulario[index] = frm_Empleado.MiEmpleado;
                    MostrarLista();
                }

            } else {
                MessageBox.Show("Selecciona algo bro");
            }
        }
    }
}
