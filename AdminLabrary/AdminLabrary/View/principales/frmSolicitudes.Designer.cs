namespace AdminLabrary.View.principales
{
    partial class frmSolicitudes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitudes));
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.IdSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Lector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUEVA = new System.Windows.Forms.DataGridViewImageColumn();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.RECIBIR = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRetrazo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSolicitudes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolicitudes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSolicitud,
            this.Lector,
            this.Libros,
            this.Cantidad,
            this.Id_Lector,
            this.Id_Libro,
            this.NUEVA,
            this.EDITAR,
            this.ELIMINAR,
            this.RECIBIR});
            this.dgvSolicitudes.GridColor = System.Drawing.Color.Gray;
            this.dgvSolicitudes.Location = new System.Drawing.Point(12, 94);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSolicitudes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSolicitudes.Size = new System.Drawing.Size(928, 445);
            this.dgvSolicitudes.TabIndex = 10;
            this.dgvSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudes_CellClick);
            this.dgvSolicitudes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudes_CellContentClick);
            // 
            // IdSolicitud
            // 
            this.IdSolicitud.HeaderText = "ID";
            this.IdSolicitud.Name = "IdSolicitud";
            this.IdSolicitud.ReadOnly = true;
            this.IdSolicitud.Visible = false;
            // 
            // Lector
            // 
            this.Lector.FillWeight = 187.1614F;
            this.Lector.HeaderText = "LECTOR";
            this.Lector.Name = "Lector";
            this.Lector.ReadOnly = true;
            // 
            // Libros
            // 
            this.Libros.FillWeight = 187.1614F;
            this.Libros.HeaderText = "LIBRO";
            this.Libros.Name = "Libros";
            this.Libros.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.FillWeight = 187.1614F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Id_Lector
            // 
            this.Id_Lector.HeaderText = "CANTIDAD";
            this.Id_Lector.Name = "Id_Lector";
            this.Id_Lector.ReadOnly = true;
            this.Id_Lector.Visible = false;
            // 
            // Id_Libro
            // 
            this.Id_Libro.HeaderText = "Id_Libro";
            this.Id_Libro.Name = "Id_Libro";
            this.Id_Libro.ReadOnly = true;
            this.Id_Libro.Visible = false;
            // 
            // NUEVA
            // 
            this.NUEVA.FillWeight = 42.35353F;
            this.NUEVA.HeaderText = "NUEVA";
            this.NUEVA.Image = ((System.Drawing.Image)(resources.GetObject("NUEVA.Image")));
            this.NUEVA.Name = "NUEVA";
            this.NUEVA.ReadOnly = true;
            // 
            // EDITAR
            // 
            this.EDITAR.FillWeight = 41.35303F;
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Image = ((System.Drawing.Image)(resources.GetObject("EDITAR.Image")));
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.ReadOnly = true;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.FillWeight = 51.70761F;
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("ELIMINAR.Image")));
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.ReadOnly = true;
            // 
            // RECIBIR
            // 
            this.RECIBIR.FillWeight = 43.69691F;
            this.RECIBIR.HeaderText = "RECIBIR";
            this.RECIBIR.Image = ((System.Drawing.Image)(resources.GetObject("RECIBIR.Image")));
            this.RECIBIR.Name = "RECIBIR";
            this.RECIBIR.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(621, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnRetrazo
            // 
            this.btnRetrazo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRetrazo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRetrazo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetrazo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRetrazo.FlatAppearance.BorderSize = 2;
            this.btnRetrazo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRetrazo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRetrazo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrazo.Image = ((System.Drawing.Image)(resources.GetObject("btnRetrazo.Image")));
            this.btnRetrazo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetrazo.Location = new System.Drawing.Point(12, 29);
            this.btnRetrazo.Name = "btnRetrazo";
            this.btnRetrazo.Size = new System.Drawing.Size(151, 45);
            this.btnRetrazo.TabIndex = 22;
            this.btnRetrazo.Text = "HISTORIAL CON RETRASO";
            this.btnRetrazo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRetrazo.UseVisualStyleBackColor = false;
            this.btnRetrazo.Click += new System.EventHandler(this.btnRetrazo_Click);
            // 
            // frmSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 551);
            this.Controls.Add(this.btnRetrazo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvSolicitudes);
            this.Name = "frmSolicitudes";
            this.Text = "frmSolicitudes";
            this.Load += new System.EventHandler(this.frmSolicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnRetrazo;
        public System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Lector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Libro;
        private System.Windows.Forms.DataGridViewImageColumn NUEVA;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
        private System.Windows.Forms.DataGridViewImageColumn RECIBIR;
    }
}