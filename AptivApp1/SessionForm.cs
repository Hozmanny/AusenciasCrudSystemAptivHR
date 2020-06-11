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
    public partial class SessionForm : Form
    {
        private int childFormNumber = 0;

        public int IdUsuario;
        public string IdRol;
        public string Nombre;
        public string Rol;
        public bool Estado;
        public SessionForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void BTNiniciarsesion_Click(object sender, EventArgs e)
        {
            // this.Hide();

            //var newwindow = new CoreForm();

            //newwindow.Show();

            try
            {
                DataTable Tabla = new DataTable();
                Tabla = NegocioUsers.Login(TBEmail.Text.Trim(), TBPassword.Text.Trim());
                if (Tabla.Rows.Count<=0)
                {
                    MessageBox.Show("No existe el usuario ingresado","Acceso al sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    CoreForm Frm = new CoreForm();
                    this.Hide();
                    Frm.Show();
                    Nombre = Convert.ToString(Tabla.Rows[0][1]);
                    Estado = Convert.ToBoolean(Tabla.Rows[0][3]);
                    MessageBox.Show("Bienvenido " + Nombre);
                    //if (Convert.ToBoolean(Tabla.Rows[0][3])==false)
                    //{
                    //    MessageBox.Show("Este usuario no esta activo", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //else
                    //{
                    //    CoreForm Frm = new CoreForm();
                    //}
                    if (Estado == false)
                    {
                        Frm.BTNaddUser.Enabled = false;
                    }
                    Frm.LBname.Text = Nombre;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
