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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NegocioEvents.Listar();
                this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NegocioEvents.Buscar(TBstartsearch.Text);
                this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato()
        {
            DgvListado.Columns[0].Width = 70;
            DgvListado.Columns[1].Width = 200;
            DgvListado.Columns[2].Width = 50;
            DgvListado.Columns[3].Width = 70;
            DgvListado.Columns[4].Width = 200;
            DgvListado.Columns[5].Width = 300;
            DgvListado.Columns[6].Width = 100;
            DgvListado.Columns[7].Width = 100;
            DgvListado.Columns[8].Width = 200;
            //DgvListado.DefaultCellStyle.BackColor = Color.FromArgb(56,57,66);
            DgvListado.DefaultCellStyle.BackColor = Color.Black;
            DgvListado.DefaultCellStyle.ForeColor = Color.White;
            DgvListado.BackgroundColor = Color.Black;
            DgvListado.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 57, 66);
            DgvListado.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DgvListado.RowsDefaultCellStyle.BackColor = Color.FromArgb(56, 57, 66);
            DgvListado.EnableHeadersVisualStyles = false;
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.Actualizar();

        }

        private void BTNadduser_Click(object sender, EventArgs e)
        {
            this.Buscar();
            this.Actualizar();
        }

        private void Actualizar()
        {
            if (TBstartsearch.Text == "")
            {
                this.Listar();
            }
        }

        private void BTNimprimir_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteEventos Reporte = new Reportes.FrmReporteEventos();
            Reporte.ShowDialog();
        }
    }
}
