using AdminLabrary.formularios.principales;
using AdminLabrary.Model;
using AdminLabrary.View.buscar;
using AdminLabrary.View.insertUpdateDelete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminLabrary.View.principales
{
    public partial class frmSolicitudes : Form
    {
        public frmSolicitudes()
        {
            InitializeComponent();

        }
        public int Loging;
        public int ID;

        public void CargarDatos()
        {
            using (BibliotecaprogramEntities db = new BibliotecaprogramEntities())
            {
                dgvSolicitudes.Rows.Clear();
                if (Loging == 0)
                {
                    var lista = from solic in db.solicitudes
                                from lec in db.Lectores
                                from Lib in db.Libros

                                where solic.id_lector == ID
                                where solic.id_lector == lec.Id_Lector
                                where solic.libros == Lib.Id_libro
                                where solic.estado == 0
                                select new
                                {
                                    ID = solic.id_soli,
                                    Lector = lec.Nombres,
                                    Libros = Lib.Nombre,
                                    Cantidad = solic.Cantidad,
                                    Estado = solic.estado,
                                    Id_Lector = lec.Id_Lector,
                                    Id_Libro = solic.libros

                                };

                    foreach (var iterar in lista)
                    {
                        if (iterar.Estado == 0)
                        {
                            dgvSolicitudes.Rows.Add(iterar.ID, iterar.Lector, iterar.Libros, iterar.Cantidad,
                            iterar.Id_Lector, iterar.Id_Libro, "Activo");
                        }
                    }
                }
                else if (Loging == 1)
                {

                    var lista = from solic in db.solicitudes
                                from Lec in db.Lectores
                                from Lib in db.Libros
                                where solic.estado == 0
                                where solic.id_lector == Lec.Id_Lector
                                where solic.libros == Lib.Id_libro
                                select new
                                {
                                    ID = solic.id_soli,
                                    Lector = Lec.Nombres,
                                    Libros = Lib.Nombre,
                                    Cantidad = solic.Cantidad,
                                    Estado = solic.estado,
                                    Id_Lector = solic.id_lector,
                                    Id_Libro = solic.libros

                                };

                    foreach (var iterar in lista)
                    {
                        if (iterar.Estado == 0)
                        {
                            dgvSolicitudes.Rows.Add(iterar.ID, iterar.Lector, iterar.Libros, iterar.Cantidad,
                            iterar.Id_Lector, iterar.Id_Libro, "activo");
                        }
                    }
                }
            }

        }

        public void Seleccionar()
        {
            int Id = int.Parse(dgvSolicitudes.CurrentRow.Cells[0].Value.ToString());
            int IdLibro = int.Parse(dgvSolicitudes.CurrentRow.Cells[5].Value.ToString());
            int IdLector = int.Parse(dgvSolicitudes.CurrentRow.Cells[4].Value.ToString());
            string Cantidad = dgvSolicitudes.CurrentRow.Cells[3].Value.ToString();
            string Libro = dgvSolicitudes.CurrentRow.Cells[2].Value.ToString();
            string Lector = dgvSolicitudes.CurrentRow.Cells[1].Value.ToString();

            solicitud.txtCantidad.Text = Cantidad;
            solicitud.txtLibro.Text = Libro;
            solicitud.ID = Id;
            solicitud.idlector = IdLector;
            solicitud.idlibro = IdLibro;


        }
        public frmSolicitudesCRUD solicitud = new frmSolicitudesCRUD();


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            solicitud.btnGuardar.Show();
            solicitud.btnGuardar.Enabled = true;
            solicitud.btnActualizar.Hide();
            solicitud.btnEliminar.Hide();
            solicitud.limpiar();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            solicitud.ShowDialog();
        }

        private void frmSolicitudes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
               
                if ( dgvSolicitudes.RowCount > 0)
                {
                    solicitud.btnGuardar.Hide();
                    solicitud.btnActualizar.Show();
                    solicitud.btnGuardar.Enabled = true;
                    solicitud.btnEliminar.Hide();
                    btnEliminar.Enabled = false;
                    btnEditar.Enabled = false;
                    Seleccionar();
                    solicitud.ShowDialog();
                }
            }
            catch
            {

            }
           
        }

        private void dgvSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnRecibir.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.RowCount > 0)
            {
                solicitud.btnGuardar.Hide();
                solicitud.btnActualizar.Hide();
                solicitud.btnEliminar.Show();
                solicitud.btnEliminar.Enabled = true;
                solicitud.btnSeleccionarLector.Hide();
                solicitud.txtCantidad.Enabled = false;
                btnEliminar.Enabled = false;
                btnEditar.Enabled = false;
                Seleccionar();
                solicitud.ShowDialog();
            }
        }

       

        private void btnRetrazo_Click(object sender, EventArgs e)
        {
            frmHistorial histo = new frmHistorial();
            histo.ShowDialog();
        }

        private void btnRecibir_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.RowCount > 0)
            {
                int IdLector = int.Parse(dgvSolicitudes.CurrentRow.Cells[4].Value.ToString());
                string Lector = dgvSolicitudes.CurrentRow.Cells[1].Value.ToString();
                int IdLibro = int.Parse(dgvSolicitudes.CurrentRow.Cells[5].Value.ToString());
                string Libro = dgvSolicitudes.CurrentRow.Cells[2].Value.ToString();
                string Cantidad = dgvSolicitudes.CurrentRow.Cells[3].Value.ToString();
                frmPrincipal.prestamos.alquiler.IdLibro = IdLibro;
                frmPrincipal.prestamos.alquiler.txtLibro.Text = Libro;
                frmPrincipal.prestamos.alquiler.txtLector.Text = Lector;
                frmPrincipal.prestamos.alquiler.idLector = IdLector;
                frmPrincipal.prestamos.alquiler.txtCantidad.Text = Cantidad;
                frmPrincipal.prestamos.alquiler.solicitud = int.Parse(dgvSolicitudes.CurrentRow.Cells[0].Value.ToString());
                frmPrincipal.prestamos.alquiler.txtCantidad.Enabled = false;
                frmPrincipal.prestamos.alquiler.btnRecibir.Hide();
                frmPrincipal.prestamos.alquiler.btnGuardar.Enabled = true;
                frmPrincipal.prestamos.alquiler.btnGuardar.Show();
                frmPrincipal.prestamos.alquiler.btnSeleccionarLector.Hide();
                frmPrincipal.prestamos.alquiler.btnSeleccionarLibro.Hide();
                frmPrincipal.prestamos.alquiler.ShowDialog();
            }
        }
    }
}
