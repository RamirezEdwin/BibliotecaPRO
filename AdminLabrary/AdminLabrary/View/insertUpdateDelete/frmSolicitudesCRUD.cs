using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminLabrary.Model;

namespace AdminLabrary.View.insertUpdateDelete
{
    public partial class frmSolicitudesCRUD : Form
    {
        public frmSolicitudesCRUD()
        {
            InitializeComponent();
        }
        solicitudes soli = new solicitudes();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using(BibliotecaprogramEntities db = new BibliotecaprogramEntities())
            {
                if (int.Parse(txtCantidad.Text) > 0)
                {
                    if (txtCantidad.Text != "" && txtLibro.Text != "")
                    {
                       
                    }
                }

            }
        }
    }
}
