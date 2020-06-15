using AdminLabrary.Model;
using AdminLabrary.Reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminLabrary.Consulta
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {

            using (BibliotecaprogramEntities db = new BibliotecaprogramEntities())
            {
                rptCategoria cat = new rptCategoria();
                cat.SetDataSource(db.Categorias.ToList());
                crpCategorias.ReportSource = cat;
            }
        }
    }
}
