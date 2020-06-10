
using AventStack.ExtentReports.Gherkin.Model;
using System;



using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AdminLabrary.View.principales;

namespace AdminLabrary.formularios.principales
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            frmLogin f = new frmLogin();




        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {


            MostrarPanel(new frmAutor());


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;


        public void MostrarPanel(Form Panel)
        {
            if (activeForm != null)
                activeForm = Panel;
            Panel.TopLevel = false;
            Panel.FormBorderStyle = FormBorderStyle.None;
            Panel.Dock = DockStyle.Fill;
            pPrincipal.Controls.Add(Panel);
            pPrincipal.Tag = Panel;
            Panel.BringToFront();
            Panel.Show();
        }


        public static frmEditorial Editorial = new frmEditorial();
        private void btnProductos_Click(object sender, EventArgs e)
        {
            color = 5;
            cambiarcolor();
            MostrarPanel(Editorial);

        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resu = MessageBox.Show("¿Desea salir de la aplicacion?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (resu == DialogResult.Yes)
            {
                Application.Exit();
            }

        }


        int Boton = 0;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (Boton == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximizar.Visible = true;
                btnMinimizar.Visible = true;
                Boton = 1;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMinimizar.Visible = true;
                btnMaximizar.Visible = true;
                Boton = 0;
            }

        }

        private void btnMinimizar_Click(object sender, EventArgs e)

        {
            this.WindowState = FormWindowState.Minimized;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int lParam, int v);

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);


        }

        private void PanelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }


        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        public static frmAdministradores admin = new frmAdministradores();
        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            color = 3;
            cambiarcolor();
            MostrarPanel(admin);
        }


        public static frmLectores lector = new frmLectores();
        private void btnLectores_Click(object sender, EventArgs e)
        {
            color = 8;
            cambiarcolor();
            MostrarPanel(lector);

        }
        public static frmCategoria categoria = new frmCategoria();
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            color = 4;
            cambiarcolor();
            MostrarPanel(categoria);

        }
        public static frmLibros Lib = new frmLibros();
        private void btnLibros_Click(object sender, EventArgs e)
        {
            color = 2;
            cambiarcolor();
            Lib.CargaDratos();

            MostrarPanel(Lib);

        }

        int color;
        void cambiarcolor()
        {
            if(color == 0)
            {
                btnPrestamos.BackColor = Color.Teal;
                btnSolicitudes.BackColor = Color.FromArgb(64,64,64,64);
                btnLibros.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnAdmin.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnCategoria.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnEditorial.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnAutor.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnRoles.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnLectores.BackColor = Color.FromArgb(64, 64, 64, 64);
            }else if (color == 1)
            {
                btnPrestamos.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnSolicitudes.BackColor = Color.Teal;
                btnLibros.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnAdmin.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnCategoria.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnEditorial.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnAutor.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnRoles.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnLectores.BackColor = Color.FromArgb(64, 64, 64, 64);
            }
            else if (color == 2)
            {
                btnPrestamos.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnSolicitudes.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnLibros.BackColor = Color.Teal;
                btnAdmin.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnCategoria.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnEditorial.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnAutor.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnRoles.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnLectores.BackColor = Color.FromArgb(64, 64, 64, 64);
            }
            else if (color == 3)
            {
                btnPrestamos.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnSolicitudes.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnLibros.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnAdmin.BackColor = Color.Teal;
                btnCategoria.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnEditorial.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnAutor.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnRoles.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnLectores.BackColor = Color.FromArgb(64, 64, 64, 64);
            }
            else if (color == 4)
            {
                btnPrestamos.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnSolicitudes.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnLibros.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnAdmin.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnCategoria.BackColor = Color.Teal;
                btnEditorial.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnAutor.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnRoles.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnLectores.BackColor = Color.FromArgb(64, 64, 64, 64);
            }
            else if (color == 5)
            {
                btnPrestamos.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnSolicitudes.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnLibros.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnAdmin.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnCategoria.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnEditorial.BackColor = Color.Teal;
                btnAutor.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnRoles.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnLectores.BackColor = Color.FromArgb(64, 64, 64, 64);
            }
            else if (color == 6)
            {
                btnPrestamos.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnSolicitudes.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnLibros.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnAdmin.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnCategoria.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnEditorial.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnAutor.BackColor = Color.Teal;
                btnRoles.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnLectores.BackColor = Color.FromArgb(64, 64, 64, 64);
            }
            else if (color == 7)
            {
                btnPrestamos.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnSolicitudes.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnLibros.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnAdmin.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnCategoria.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnEditorial.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnAutor.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnRoles.BackColor = Color.Teal;
                btnLectores.BackColor = Color.FromArgb(64, 64, 64, 64);
            }
            else if (color == 8)
            {
                btnPrestamos.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnSolicitudes.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnLibros.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnAdmin.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnCategoria.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnEditorial.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnAutor.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnRoles.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnLectores.BackColor = Color.Teal;
            }
            else if (color == 9)
            {
                btnPrestamos.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnSolicitudes.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnLibros.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnAdmin.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnCategoria.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnEditorial.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnAutor.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnRoles.BackColor = Color.FromArgb(64, 64, 64, 64);
                btnLectores.BackColor = Color.FromArgb(64, 64, 64, 64);
            }

        }

        public static frmPrestamos prestamos = new frmPrestamos();
        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            color = 0;
            cambiarcolor();
            MostrarPanel(prestamos);


        }

        public static frmAutor Autor = new frmAutor();
        private void btnAutor_Click(object sender, EventArgs e)
        {
            color = 6;
            cambiarcolor();
            MostrarPanel(Autor);
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            PanelMenu.Hide();
            picce2.Show();
            btnMostrar.Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            PanelMenu.Show();
            picce2.Hide();
            btnMostrar.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pPrincipal_Paint_1(object sender, PaintEventArgs e)
        {

        }
         public static frmRoles r = new frmRoles();
        private void btnRoles_Click(object sender, EventArgs e)
        {
            color = 7;
            cambiarcolor();
            MostrarPanel(r);
        }
        public static frmSolicitudes Sol = new frmSolicitudes();
        private void button2_Click(object sender, EventArgs e)
        {
            color = 1;
            cambiarcolor();
            Sol.CargarDatos();

            MostrarPanel(Sol);
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            picLogo.BringToFront();
            color = 9;
            cambiarcolor();
        }
        public int rol;
        public void roles()
        {
            if (rol == 0)
            {
                frmPrincipal.Lib.btnEditar.Hide();
                frmPrincipal.Lib.btnEliminar.Hide();
                frmPrincipal.Lib.btnNuevo.Hide();
                frmPrincipal.Sol.btnRecibir.Hide();
                frmPrincipal.Sol.btnRetrazo.Hide();
                btnPrestamos.Hide();
                btnAdmin.Hide();
                btnCategoria.Hide();
                btnAutor.Hide();
                btnEditorial.Hide();
                btnRoles.Hide();
                btnLectores.Hide();
            }
            else
            {
                frmPrincipal.Lib.btnEditar.Show();
                frmPrincipal.Lib.btnEliminar.Show();
                frmPrincipal.Lib.btnNuevo.Show();
                frmPrincipal.Sol.btnRecibir.Show();
                frmPrincipal.Sol.btnRetrazo.Show();
                btnPrestamos.Show();
                btnAdmin.Show();
                btnCategoria.Show();
                btnAutor.Show();
                btnEditorial.Show();
                btnRoles.Show();
                btnLectores.Show();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }
    }

}

