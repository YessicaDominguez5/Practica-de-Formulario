using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); //cierra el formulario
           
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = "";
                
            int contdedatos = 0;

            List<TextBox> lista = new List<TextBox>();

            lista.Add(textBoxApellido);
            lista.Add(textBoxNombre);
            lista.Add(textBoxEdad);
            lista.Add(textBoxDireccion);


            foreach(TextBox item in lista)
            {
               // if( item.Text == "")
               if(string.IsNullOrEmpty(item.Text))
                {
                    item.BackColor = Color.Red;

                } 
                else
                {
                    contdedatos++;
                    item.BackColor =Color.White; 
                }


            }

            if (contdedatos == 4)
            {
                //textBoxResultado.Text = "Apellido: " + textBoxApellido.Text + "\r Nombre: " + textBoxNombre.Text ; 

                textBoxResultado.AppendText("Apellido: " + textBoxApellido.Text + Environment.NewLine);
                textBoxResultado.AppendText("Nombre: " + textBoxNombre.Text + Environment.NewLine);
                textBoxResultado.AppendText("Edad: " + textBoxEdad.Text + Environment.NewLine);
                textBoxResultado.AppendText("Diección: " + textBoxDireccion.Text + Environment.NewLine);

            }
             


        }

        private void textBoxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
    