using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Formsitou : Form
    {
        //private string mensaje;

        public Formsitou()
        {
            InitializeComponent();
        }

        private void Saludar_OnClick(object sender, EventArgs e)
        {
            string nombre = this.textNombre.Text;

            if (ValidarNombre(nombre))
            {
                nombre = nombre.Trim(); //en realidad devuelve un string nuevo, no pisa el anterior, son inmutables
                string mensaje = $"hi {nombre}, go to sleep";
                ///// instancia el nuevo form porque sino no se hace automáticamente 
                Formsitou formsitou = new Formsitou(mensaje);
                // formsitou.Show(); puedo abrir mil ventanas e interactuar con todas, NO MODAL

                formsitou.ShowDialog();
            }

            else
            {
                DialogResult result = MessageBox.Show("¿Desea continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    this.Close();
                }
            }

            //MessageBox.Show($"hi {nombre}, go to sleep", "SALUDAR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private bool ValidarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Error, ingrese un nombre", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            return true;


        }
    }
}
