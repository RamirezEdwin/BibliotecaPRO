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
using AdminLabrary.formularios.principales;
using AdminLabrary.View.buscar;

namespace AdminLabrary.View.insertUpdateDelete
{
    public partial class frmSolicitudesCRUD : Form
    {
        public frmSolicitudesCRUD()
        {
            InitializeComponent();
            limpiar();
            
           
        }
        frmBuscarLibros BuscarL = new frmBuscarLibros();
        public void limpiar()
        {
            
            txtCantidad.Text = "";
            

        }
        public int idlector;
        public int cantidad;
        public int idlibro;
        solicitudes soli = new solicitudes();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using(BibliotecaprogramEntities db = new BibliotecaprogramEntities())
            {
                if (int.Parse(txtCantidad.Text) > 0)
                {

                    if (txtCantidad.Text != "" && txtLibro.Text != "")
                    {

                        soli.Cantidad = int.Parse(txtCantidad.Text);
                        soli.libros = idlibro;
                        soli.id_lector = idlector;
                        soli.estado = 0;
                        db.solicitudes.Add(soli);
                        db.SaveChanges();
                        limpiar();
                        frmPrincipal.Sol.CargarDatos();
                        this.Close();

                    }


                
                }

            }
        }

        private void btnSeleccionarLector_Click(object sender, EventArgs e)
        {
            BuscarL.indicador = 1;
            BuscarL.ShowDialog();
        }
    }
}
