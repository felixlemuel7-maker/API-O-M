namespace Periodoacademico26
{
    partial class CarrerasControl
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
            this.lblTituloModulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.cardFormulario = new System.Windows.Forms.Panel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnNuevo = new Periodoacademico26.RoundedButton();
            this.btnGuardar = new Periodoacademico26.RoundedButton();
            this.btnEliminar = new Periodoacademico26.RoundedButton();
            this.btnLimpiar = new Periodoacademico26.RoundedButton();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.cardGrid = new System.Windows.Forms.Panel();
            this.dgvCarreras = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblListado = new System.Windows.Forms.Label();
            this.cardFormulario.SuspendLayout();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).BeginInit();
            this.SuspendLayout();
            //
            // lblTituloModulo
            //
            this.lblTituloModulo.AutoSize = true;
            this.lblTituloModulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloModulo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0B2545");
            this.lblTituloModulo.Location = new System.Drawing.Point(30, 20);
            this.lblTituloModulo.Name = "lblTituloModulo";
            this.lblTituloModulo.Size = new System.Drawing.Size(280, 32);
            this.lblTituloModulo.TabIndex = 0;
            this.lblTituloModulo.Text = "Módulo de Carreras";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitulo.Location = new System.Drawing.Point(30, 55);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(430, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Administra las carreras académicas que ofrece la universidad.";
            //
            // cardFormulario
            //
            this.cardFormulario.BackColor = System.Drawing.Color.White;
            this.cardFormulario.Controls.Add(this.lblCodigo);
            this.cardFormulario.Controls.Add(this.txtCodigo);
            this.cardFormulario.Controls.Add(this.lblNombre);
            this.cardFormulario.Controls.Add(this.txtNombre);
            this.cardFormulario.Controls.Add(this.btnNuevo);
            this.cardFormulario.Controls.Add(this.btnGuardar);
            this.cardFormulario.Controls.Add(this.btnEliminar);
            this.cardFormulario.Controls.Add(this.btnLimpiar);
            this.cardFormulario.Location = new System.Drawing.Point(30, 90);
            this.cardFormulario.Name = "cardFormulario";
            this.cardFormulario.Size = new System.Drawing.Size(1050, 150);
            this.cardFormulario.TabIndex = 2;
            this.cardFormulario.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            //
            // lblCodigo
            //
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.lblCodigo.Location = new System.Drawing.Point(20, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(48, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            //
            // txtCodigo
            //
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCodigo.Location = new System.Drawing.Point(20, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(160, 25);
            this.txtCodigo.TabIndex = 1;
            //
            // lblNombre
            //
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNombre.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombre.Location = new System.Drawing.Point(200, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(120, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre de la carrera";
            //
            // txtNombre
            //
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(200, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(400, 25);
            this.txtNombre.TabIndex = 3;
            //
            // btnNuevo
            //
            this.btnNuevo.BackColor = System.Drawing.ColorTranslator.FromHtml("#13315C");
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(20, 105);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.RadioBorde = 10;
            this.btnNuevo.Size = new System.Drawing.Size(110, 38);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            //
            // btnGuardar
            //
            this.btnGuardar.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A227");
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0B2545");
            this.btnGuardar.Location = new System.Drawing.Point(140, 105);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.RadioBorde = 10;
            this.btnGuardar.Size = new System.Drawing.Size(110, 38);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            //
            // btnEliminar
            //
            this.btnEliminar.BackColor = System.Drawing.ColorTranslator.FromHtml("#C0392B");
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(260, 105);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.RadioBorde = 10;
            this.btnEliminar.Size = new System.Drawing.Size(110, 38);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            //
            // btnLimpiar
            //
            this.btnLimpiar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0B2545");
            this.btnLimpiar.Location = new System.Drawing.Point(380, 105);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.RadioBorde = 10;
            this.btnLimpiar.Size = new System.Drawing.Size(110, 38);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            //
            // lblMensaje
            //
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblMensaje.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2E8B57");
            this.lblMensaje.Location = new System.Drawing.Point(30, 250);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 17);
            this.lblMensaje.TabIndex = 3;
            //
            // cardGrid
            //
            this.cardGrid.BackColor = System.Drawing.Color.White;
            this.cardGrid.Controls.Add(this.dgvCarreras);
            this.cardGrid.Controls.Add(this.txtBuscar);
            this.cardGrid.Controls.Add(this.lblListado);
            this.cardGrid.Location = new System.Drawing.Point(30, 280);
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Size = new System.Drawing.Size(1050, 380);
            this.cardGrid.TabIndex = 4;
            this.cardGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            //
            // dgvCarreras
            //
            this.dgvCarreras.AllowUserToAddRows = false;
            this.dgvCarreras.AllowUserToDeleteRows = false;
            this.dgvCarreras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarreras.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarreras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCarreras.ColumnHeadersHeight = 36;
            this.dgvCarreras.EnableHeadersVisualStyles = false;
            this.dgvCarreras.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvCarreras.Location = new System.Drawing.Point(20, 50);
            this.dgvCarreras.MultiSelect = false;
            this.dgvCarreras.Name = "dgvCarreras";
            this.dgvCarreras.ReadOnly = true;
            this.dgvCarreras.RowHeadersVisible = false;
            this.dgvCarreras.RowTemplate.Height = 32;
            this.dgvCarreras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarreras.Size = new System.Drawing.Size(1010, 310);
            this.dgvCarreras.TabIndex = 0;
            this.dgvCarreras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCarreras_CellClick);
            //
            // txtBuscar
            //
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(830, 15);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 25);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Text = "Buscar por nombre...";
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.TxtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.TxtBuscar_Leave);
            //
            // lblListado
            //
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblListado.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0B2545");
            this.lblListado.Location = new System.Drawing.Point(20, 15);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(160, 21);
            this.lblListado.TabIndex = 2;
            this.lblListado.Text = "Carreras registradas";
            //
            // CarrerasControl
            //
            this.AutoScroll = true;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F4F6F9");
            this.Controls.Add(this.cardGrid);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.cardFormulario);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTituloModulo);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "CarrerasControl";
            this.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.Size = new System.Drawing.Size(950, 681);
            this.cardFormulario.ResumeLayout(false);
            this.cardFormulario.PerformLayout();
            this.cardGrid.ResumeLayout(false);
            this.cardGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloModulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel cardFormulario;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private RoundedButton btnNuevo;
        private RoundedButton btnGuardar;
        private RoundedButton btnEliminar;
        private RoundedButton btnLimpiar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel cardGrid;
        private System.Windows.Forms.DataGridView dgvCarreras;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblListado;
    }
}
