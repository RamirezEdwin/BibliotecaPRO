namespace AdminLabrary.formularios.principales
{
    partial class frmAutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutor));
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NACIONALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHANACIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUEVO = new System.Windows.Forms.DataGridViewImageColumn();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAutores
            // 
            this.dgvAutores.AllowUserToAddRows = false;
            this.dgvAutores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAutores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAutores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutores.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.NACIONALIDAD,
            this.FECHANACIMIENTO,
            this.NUEVO,
            this.EDITAR,
            this.ELIMINAR});
            this.dgvAutores.GridColor = System.Drawing.Color.Lime;
            this.dgvAutores.Location = new System.Drawing.Point(0, 222);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAutores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAutores.Size = new System.Drawing.Size(938, 334);
            this.dgvAutores.TabIndex = 0;
            this.dgvAutores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutores_CellClick);
            this.dgvAutores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutores_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NOMBRE
            // 
            this.NOMBRE.FillWeight = 157.8722F;
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // NACIONALIDAD
            // 
            this.NACIONALIDAD.FillWeight = 157.8722F;
            this.NACIONALIDAD.HeaderText = "NACIONALIDAD";
            this.NACIONALIDAD.Name = "NACIONALIDAD";
            this.NACIONALIDAD.ReadOnly = true;
            // 
            // FECHANACIMIENTO
            // 
            this.FECHANACIMIENTO.FillWeight = 157.8722F;
            this.FECHANACIMIENTO.HeaderText = "FECHA NACIMIENTO";
            this.FECHANACIMIENTO.Name = "FECHANACIMIENTO";
            this.FECHANACIMIENTO.ReadOnly = true;
            // 
            // NUEVO
            // 
            this.NUEVO.FillWeight = 46.68264F;
            this.NUEVO.HeaderText = "NUEVO";
            this.NUEVO.Image = ((System.Drawing.Image)(resources.GetObject("NUEVO.Image")));
            this.NUEVO.Name = "NUEVO";
            this.NUEVO.ReadOnly = true;
            // 
            // EDITAR
            // 
            this.EDITAR.FillWeight = 40.10691F;
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Image = ((System.Drawing.Image)(resources.GetObject("EDITAR.Image")));
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.ReadOnly = true;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.FillWeight = 39.59391F;
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("ELIMINAR.Image")));
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.ReadOnly = true;
            this.ELIMINAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ELIMINAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(665, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 217);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 551);
            this.Controls.Add(this.dgvAutores);
            this.Controls.Add(this.panel1);
            this.Name = "frmAutor";
            this.Text = "AdminLabrary-autor";
            this.Load += new System.EventHandler(this.FpAutor_Load);
            this.Click += new System.EventHandler(this.btnNuevo_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    
        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NACIONALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHANACIMIENTO;
        private System.Windows.Forms.DataGridViewImageColumn NUEVO;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
    }
}