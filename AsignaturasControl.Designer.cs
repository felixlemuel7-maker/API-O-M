namespace Periodoacademico26
{
    partial class AsignaturasControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            lblTituloModulo = new Label();
            lblSubtitulo = new Label();
            cardFormulario = new Panel();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCreditos = new Label();
            txtCreditos = new TextBox();
            lblCarrera = new Label();
            cmbCarrera = new ComboBox();
            lblCuatrimestre = new Label();
            txtCuatrimestre = new TextBox();
            btnNuevo = new RoundedButton();
            btnGuardar = new RoundedButton();
            btnEliminar = new RoundedButton();
            btnLimpiar = new RoundedButton();
            lblMensaje = new Label();
            cardGrid = new Panel();
            dgvAsignaturas = new DataGridView();
            txtBuscar = new TextBox();
            lblListado = new Label();
            cardFormulario.SuspendLayout();
            cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsignaturas).BeginInit();
            SuspendLayout();
            // 
            // lblTituloModulo
            // 
            lblTituloModulo.AutoSize = true;
            lblTituloModulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloModulo.ForeColor = Color.FromArgb(11, 37, 69);
            lblTituloModulo.Location = new Point(30, 20);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new Size(412, 48);
            lblTituloModulo.TabIndex = 0;
            lblTituloModulo.Text = "Módulo de Asignaturas";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(30, 55);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(550, 28);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Administra las asignaturas y a qué carrera pertenece cada una.";
            // 
            // cardFormulario
            // 
            cardFormulario.BackColor = Color.White;
            cardFormulario.Controls.Add(lblCodigo);
            cardFormulario.Controls.Add(txtCodigo);
            cardFormulario.Controls.Add(lblNombre);
            cardFormulario.Controls.Add(txtNombre);
            cardFormulario.Controls.Add(lblCreditos);
            cardFormulario.Controls.Add(txtCreditos);
            cardFormulario.Controls.Add(lblCarrera);
            cardFormulario.Controls.Add(cmbCarrera);
            cardFormulario.Controls.Add(lblCuatrimestre);
            cardFormulario.Controls.Add(txtCuatrimestre);
            cardFormulario.Controls.Add(btnNuevo);
            cardFormulario.Controls.Add(btnGuardar);
            cardFormulario.Controls.Add(btnEliminar);
            cardFormulario.Controls.Add(btnLimpiar);
            cardFormulario.Location = new Point(30, 90);
            cardFormulario.Name = "cardFormulario";
            cardFormulario.Size = new Size(1050, 150);
            cardFormulario.TabIndex = 2;
            cardFormulario.Paint += Card_Paint;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 8.5F);
            lblCodigo.ForeColor = Color.DimGray;
            lblCodigo.Location = new Point(20, 18);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(65, 23);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 10F);
            txtCodigo.Location = new Point(20, 38);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(160, 34);
            txtCodigo.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 8.5F);
            lblNombre.ForeColor = Color.DimGray;
            lblNombre.Location = new Point(200, 18);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(200, 23);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre de la asignatura";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(200, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 34);
            txtNombre.TabIndex = 3;
            // 
            // lblCreditos
            // 
            lblCreditos.AutoSize = true;
            lblCreditos.Font = new Font("Segoe UI", 8.5F);
            lblCreditos.ForeColor = Color.DimGray;
            lblCreditos.Location = new Point(500, 18);
            lblCreditos.Name = "lblCreditos";
            lblCreditos.Size = new Size(73, 23);
            lblCreditos.TabIndex = 4;
            lblCreditos.Text = "Créditos";
            // 
            // txtCreditos
            // 
            txtCreditos.Font = new Font("Segoe UI", 10F);
            txtCreditos.Location = new Point(500, 38);
            txtCreditos.Name = "txtCreditos";
            txtCreditos.Size = new Size(80, 34);
            txtCreditos.TabIndex = 5;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Segoe UI", 8.5F);
            lblCarrera.ForeColor = Color.DimGray;
            lblCarrera.Location = new Point(610, 18);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(66, 23);
            lblCarrera.TabIndex = 6;
            lblCarrera.Text = "Carrera";
            // 
            // cmbCarrera
            // 
            cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarrera.Font = new Font("Segoe UI", 10F);
            cmbCarrera.Location = new Point(610, 38);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(270, 36);
            cmbCarrera.TabIndex = 7;
            // 
            // lblCuatrimestre
            // 
            lblCuatrimestre.AutoSize = true;
            lblCuatrimestre.Font = new Font("Segoe UI", 8.5F);
            lblCuatrimestre.ForeColor = Color.DimGray;
            lblCuatrimestre.Location = new Point(900, 18);
            lblCuatrimestre.Name = "lblCuatrimestre";
            lblCuatrimestre.Size = new Size(108, 23);
            lblCuatrimestre.TabIndex = 20;
            lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // txtCuatrimestre
            // 
            txtCuatrimestre.Font = new Font("Segoe UI", 10F);
            txtCuatrimestre.Location = new Point(900, 38);
            txtCuatrimestre.Name = "txtCuatrimestre";
            txtCuatrimestre.Size = new Size(130, 34);
            txtCuatrimestre.TabIndex = 21;
            txtCuatrimestre.Text = "1";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(19, 49, 92);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(20, 105);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.RadioBorde = 10;
            btnNuevo.Size = new Size(110, 38);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += BtnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(201, 162, 39);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.FromArgb(11, 37, 69);
            btnGuardar.Location = new Point(140, 105);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.RadioBorde = 10;
            btnGuardar.Size = new Size(110, 38);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += BtnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 57, 43);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(260, 105);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.RadioBorde = 10;
            btnEliminar.Size = new Size(110, 38);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += BtnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gainsboro;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.FromArgb(11, 37, 69);
            btnLimpiar.Location = new Point(380, 105);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.RadioBorde = 10;
            btnLimpiar.Size = new Size(110, 38);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += BtnLimpiar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            lblMensaje.ForeColor = Color.FromArgb(46, 139, 87);
            lblMensaje.Location = new Point(30, 250);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 25);
            lblMensaje.TabIndex = 3;
            // 
            // cardGrid
            // 
            cardGrid.BackColor = Color.White;
            cardGrid.Controls.Add(dgvAsignaturas);
            cardGrid.Controls.Add(txtBuscar);
            cardGrid.Controls.Add(lblListado);
            cardGrid.Location = new Point(30, 280);
            cardGrid.Name = "cardGrid";
            cardGrid.Size = new Size(1050, 380);
            cardGrid.TabIndex = 4;
            cardGrid.Paint += Card_Paint;
            // 
            // dgvAsignaturas
            // 
            dgvAsignaturas.AllowUserToAddRows = false;
            dgvAsignaturas.AllowUserToDeleteRows = false;
            dgvAsignaturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsignaturas.BackgroundColor = Color.White;
            dgvAsignaturas.BorderStyle = BorderStyle.None;
            dgvAsignaturas.ColumnHeadersHeight = 36;
            dgvAsignaturas.EnableHeadersVisualStyles = false;
            dgvAsignaturas.Font = new Font("Segoe UI", 9.5F);
            dgvAsignaturas.Location = new Point(20, 50);
            dgvAsignaturas.MultiSelect = false;
            dgvAsignaturas.Name = "dgvAsignaturas";
            dgvAsignaturas.ReadOnly = true;
            dgvAsignaturas.RowHeadersVisible = false;
            dgvAsignaturas.RowHeadersWidth = 62;
            dgvAsignaturas.RowTemplate.Height = 32;
            dgvAsignaturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsignaturas.Size = new Size(1010, 310);
            dgvAsignaturas.TabIndex = 0;
            dgvAsignaturas.CellClick += DgvAsignaturas_CellClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9.5F);
            txtBuscar.ForeColor = Color.Gray;
            txtBuscar.Location = new Point(830, 15);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(200, 33);
            txtBuscar.TabIndex = 1;
            txtBuscar.Text = "Buscar por nombre...";
            txtBuscar.TextChanged += TxtBuscar_TextChanged;
            txtBuscar.Enter += TxtBuscar_Enter;
            txtBuscar.Leave += TxtBuscar_Leave;
            // 
            // lblListado
            // 
            lblListado.AutoSize = true;
            lblListado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblListado.ForeColor = Color.FromArgb(11, 37, 69);
            lblListado.Location = new Point(20, 15);
            lblListado.Name = "lblListado";
            lblListado.Size = new Size(284, 32);
            lblListado.TabIndex = 2;
            lblListado.Text = "Asignaturas registradas";
            // 
            // AsignaturasControl
            // 
            AutoScroll = true;
            BackColor = Color.FromArgb(244, 246, 249);
            Controls.Add(cardGrid);
            Controls.Add(lblMensaje);
            Controls.Add(cardFormulario);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTituloModulo);
            Font = new Font("Segoe UI", 9.5F);
            Name = "AsignaturasControl";
            Padding = new Padding(30, 20, 30, 20);
            Size = new Size(2497, 1312);
            cardFormulario.ResumeLayout(false);
            cardFormulario.PerformLayout();
            cardGrid.ResumeLayout(false);
            cardGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsignaturas).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloModulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel cardFormulario;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.TextBox txtCuatrimestre;
        private RoundedButton btnNuevo;
        private RoundedButton btnGuardar;
        private RoundedButton btnEliminar;
        private RoundedButton btnLimpiar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel cardGrid;
        private System.Windows.Forms.DataGridView dgvAsignaturas;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblListado;
    }
}
