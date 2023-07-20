using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Formulario
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void cargarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach(var item in Application.OpenForms)
            {

                if(item.GetType() == typeof(Form1))
                {
                    return;
                }

            }
            Form1 ventana= new Form1();
            //ventana.ShowDialog();
            ventana.MdiParent = this;
            ventana.Show();
        }

      
        private void toolStripButtonCargarPerfil_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {

                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe una ventana abierta.");
                    return;
                }

            }
            Form1 ventana = new Form1();
            //ventana.ShowDialog();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
