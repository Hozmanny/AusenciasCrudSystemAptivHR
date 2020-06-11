using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AptivApp1.Reportes
{
    public partial class FrmReporteEventos : Form
    {
        public FrmReporteEventos()
        {
            InitializeComponent();
        }

        private void FrmReporteEventos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsAptiv.Eventos_Listar' table. You can move, or remove it, as needed.
            this.Eventos_ListarTableAdapter.Fill(this.DsAptiv.Eventos_Listar);

            this.reportViewer1.RefreshReport();
        }
    }
}
