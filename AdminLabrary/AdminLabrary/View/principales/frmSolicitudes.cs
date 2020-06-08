using AdminLabrary.Model;
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
            using ( BibliotecaprogramEntities db = new BibliotecaprogramEntities())
            {
               
                if (Loging == 0)
                {
                    var lista = from solic in db.solicitudes 
                                from Lec in db.Lectores
                                from Lib in db.Libros
                                
                                where solic.id_lector == ID
                                where solic.id_lector == Lec.Id_Lector 
                                where solic.libros == Lib.Id_libro
                                where solic.estado == 0
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

                    foreach(var iterar in lista)
                    {
                        if(iterar.Estado == 0)
                        {
                            dgvSolicitudes.Rows.Add(iterar.ID, iterar.Lector, iterar.Libros, iterar.Cantidad, 
                            iterar.Id_Lector, iterar.Id_Libro,  "Activo");
                        }
                    }
                }
                else
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
                            iterar.Id_Lector, iterar.Id_Libro, "Inactivo");
                        }
                    }
                }
            }
          
        }

        public  frmSolicitudesCRUD solicitud = new frmSolicitudesCRUD();


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            solicitud.Show();
        }

        private void frmSolicitudes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
