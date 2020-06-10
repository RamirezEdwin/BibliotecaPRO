
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
using AdminLabrary.View.insertUpdateDelete;

namespace AdminLabrary.formularios.principales
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void FpCategoria_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void CargarDatos()
        {
            using (BibliotecaprogramEntities db = new BibliotecaprogramEntities())
            {
                var lista = from cat in db.Categorias
                            where cat.estado ==0
                            select new {ID = cat.Id_categoria,Categoria =cat.Categoria };
                dgvCat.DataSource = lista.ToList();
                
            }

        }
        void seleccionar()
        {
            int Id = int.Parse(dgvCat.CurrentRow.Cells[0].Value.ToString());
            string cate = dgvCat.CurrentRow.Cells[1].Value.ToString();
            categoria.txtCategoria.Text = cate;
            categoria.ID = Id;
        }

        private void dgvCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

        }

        frmCategoriasCRUD categoria = new frmCategoriasCRUD();
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            categoria.btnGuardar.Show();
            categoria.btnEditar.Hide();
            categoria.btnEliminar.Hide();
            categoria.btnGuardar.Enabled = true;
            categoria.limpiar();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            categoria.ShowDialog();
          
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            seleccionar();
            categoria.btnEditar.Enabled = true;
            categoria.btnGuardar.Hide();
            categoria.btnEditar.Show();
            categoria.btnEliminar.Hide();
            categoria.ShowDialog();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            seleccionar();
            categoria.btnEliminar.Enabled = true;
            categoria.btnGuardar.Hide();
            categoria.btnEditar.Hide();
            categoria.btnEliminar.Show();
            categoria.txtCategoria.Enabled = false;
            categoria.ShowDialog();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }
    }
}
