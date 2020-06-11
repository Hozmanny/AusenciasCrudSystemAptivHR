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
using AptivApp1;

namespace AptivApp1
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
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
                if (TBemailuser.Text == string.Empty || TBnameuser.Text == string.Empty || TBpassworduser.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos.");
                }
                else
                {
                    Rpta = NegocioUsers.Insertar(TBemailuser.Text.Trim(), TBnameuser.Text.Trim(), TBpassworduser.Text.Trim(),Convert.ToBoolean(checkBox1.Checked));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el registro");
                        TBemailuser.Text = string.Empty;
                        TBnameuser.Text = string.Empty;
                        TBpassworduser.Text = string.Empty;
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
    }
}
