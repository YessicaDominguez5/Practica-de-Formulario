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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //Cuando carga la ventana completar la colección del combo box
        {
            comboBoxLibroHP.Items.Add("Harry Potter and the Philosopher's Stone");
            comboBoxLibroHP.Items.Add("Harry Potter and the Chamber of Secrets");
            comboBoxLibroHP.Items.Add("Harry Potter and the Prisoner of Azkaban");
            comboBoxLibroHP.Items.Add("Harry Potter and the Goblet of Fire");
            comboBoxLibroHP.Items.Add("Harry Potter and the Order of the Phoenix");
            comboBoxLibroHP.Items.Add("Harry Potter and the Half-Blood Prince");
            comboBoxLibroHP.Items.Add("Harry Potter and the Deathly Hallows");
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string Nombre = textBox1.Text;
            //string Fecha = dateTimePicker1.Value.ToString();
            DateTime Fecha = dateTimePicker1.Value;
            string Cuadradito = checkBoxHambre.Checked == true ? Nombre + " tiene hambre. " : Nombre + " no tiene hambre.";
            string Tipo;
            if(radioButtonWizard.Checked == true){ Tipo = " Es Mago. "; }
            else if(radioButtonMuggle.Checked == true) {Tipo = " Es Muggle.";}
            else { Tipo = " Es Squib."; }
            string LibroFavorito = comboBoxLibroHP.SelectedItem.ToString();

            MessageBox.Show("Nombre Completo: " + Nombre + ". Fecha de Nacimiento: " + Fecha.ToShortDateString() + ". " + Cuadradito + Tipo + " Libro de HP favorito: " + LibroFavorito + ".");
        }
    }
}
