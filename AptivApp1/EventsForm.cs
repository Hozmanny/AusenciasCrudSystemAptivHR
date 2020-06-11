using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AptivAppNegocio;

namespace AptivApp1
{
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {

        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Ausencias", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Ausencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTNadduser_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TBnameemp.Text == string.Empty || TBlineemp.Text == string.Empty || TBnumberemp.Text == string.Empty|| CBeventemp.Text == string.Empty || CBworkshiftemp.Text == string.Empty || DTPstartemp.Text == string.Empty || DTPendemp.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar datos obligatorios.");
                }
                else
                {
                    Rpta = NegocioEvents.Insertar(Convert.ToInt32(TBnumberemp.Text.Trim()), TBnameemp.Text.Trim(), TBlineemp.Text.Trim(), CBworkshiftemp.Text.Trim(), CBeventemp.Text.Trim(), DTPstartemp.Text.Trim(), DTPendemp.Text.Trim(), TBcommentemp.Text.Trim(), TBregistredbyemp.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el evento");
                        TBnameemp.Text = string.Empty;
                        TBlineemp.Text = string.Empty;
                        TBnumberemp.Text = string.Empty;
                        TBcommentemp.Text = string.Empty;
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
