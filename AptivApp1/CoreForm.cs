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
    public partial class CoreForm : Form
    {
        public string Numbre;
        public CoreForm()
        {
            InitializeComponent();
            customDesing();
        }
        private void CoreForm_Load(object sender, EventArgs e)
        {
            
        }
        private void customDesing()
        {
            panelEmpleados.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelEmpleados.Visible == true)
            {
                panelEmpleados.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void BTNaddUser_Click(object sender, EventArgs e)
        {
            BTNaddUser.BackColor = Color.FromArgb(248,64,24);
            BTNemployees.BackColor = Color.FromArgb(56,57,66);
            hideSubMenu();

            AddUserForm auf = new AddUserForm();
            openChildForm(auf);
            Numbre = LBname.Text;
            auf.TBregistred.Text = Numbre;
        }

        private void BTNemployees_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmpleados);
            BTNemployees.BackColor = Color.FromArgb(248, 64, 24);
            BTNaddUser.BackColor = Color.FromArgb(56, 57, 66);
            
        }

        private void BTNsearch_Click(object sender, EventArgs e)
        {
            //..
            //Code
            //..
            //hideSubMenu();
            openChildForm(new SearchForm());
        }

        private void BTNevents_Click(object sender, EventArgs e)
        {
            //..
            //Code
            //..
            //hideSubMenu();
            EventsForm Efrm = new EventsForm();
            openChildForm(Efrm);
            Numbre = LBname.Text;
            Efrm.TBregistredbyemp.Text = Numbre;

        }

        private void BTNclosesession_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Deseas salir del sistema?", "Sistema de ausentismos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
