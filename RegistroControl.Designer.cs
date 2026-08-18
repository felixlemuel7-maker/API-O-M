namespace Periodoacademico26
{
    partial class RegistroControl
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblCedula = new Label();
            txtCedula = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblContra = new Label();
            txtContra = new TextBox();
            btnRegistrar = new RoundedButton();
            btnLimpiar = new RoundedButton();
            lblMensaje = new Label();
            cardFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloModulo
            // 
            lblTituloModulo.AutoSize = true;
            lblTituloModulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloModulo.ForeColor = Color.FromArgb(11, 37, 69);
            lblTituloModulo.Location = new Point(30, 20);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new Size(414, 48);
            lblTituloModulo.TabIndex = 0;
            lblTituloModulo.Text = "Registro de Estudiantes";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(30, 55);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(842, 28);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Crea la cuenta del estudiante. La inscripción a una carrera se hace en el módulo de Inscripciones.";
            // 
            // cardFormulario
            // 
            cardFormulario.BackColor = Color.White;
            cardFormulario.Controls.Add(lblNombre);
            cardFormulario.Controls.Add(txtNombre);
            cardFormulario.Controls.Add(lblApellido);
            cardFormulario.Controls.Add(txtApellido);
            cardFormulario.Controls.Add(lblCedula);
            cardFormulario.Controls.Add(txtCedula);
            cardFormulario.Controls.Add(lblCorreo);
            cardFormulario.Controls.Add(txtCorreo);
            cardFormulario.Controls.Add(lblContra);
            cardFormulario.Controls.Add(txtContra);
            cardFormulario.Controls.Add(btnRegistrar);
            cardFormulario.Controls.Add(btnLimpiar);
            cardFormulario.Location = new Point(30, 90);
            cardFormulario.Name = "cardFormulario";
            cardFormulario.Size = new Size(1050, 150);
            cardFormulario.TabIndex = 2;
            cardFormulario.Paint += Card_Paint;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 8.5F);
            lblNombre.ForeColor = Color.DimGray;
            lblNombre.Location = new Point(20, 18);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(20, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(190, 34);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 8.5F);
            lblApellido.ForeColor = Color.DimGray;
            lblApellido.Location = new Point(230, 18);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(72, 23);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 10F);
            txtApellido.Location = new Point(230, 38);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(190, 34);
            txtApellido.TabIndex = 3;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI", 8.5F);
            lblCedula.ForeColor = Color.DimGray;
            lblCedula.Location = new Point(440, 18);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(63, 23);
            lblCedula.TabIndex = 4;
            lblCedula.Text = "Cédula";
            // 
            // txtCedula
            // 
            txtCedula.Font = new Font("Segoe UI", 10F);
            txtCedula.Location = new Point(440, 38);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(170, 34);
            txtCedula.TabIndex = 5;
            txtCedula.TextChanged += TxtCedula_TextChanged;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 8.5F);
            lblCorreo.ForeColor = Color.DimGray;
            lblCorreo.Location = new Point(630, 18);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(121, 23);
            lblCorreo.TabIndex = 6;
            lblCorreo.Text = "Correo (Gmail)";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 10F);
            txtCorreo.Location = new Point(630, 38);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(200, 34);
            txtCorreo.TabIndex = 7;
            // 
            // lblContra
            // 
            lblContra.AutoSize = true;
            lblContra.Font = new Font("Segoe UI", 8.5F);
            lblContra.ForeColor = Color.DimGray;
            lblContra.Location = new Point(850, 18);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(97, 23);
            lblContra.TabIndex = 8;
            lblContra.Text = "Contraseña";
            // 
            // txtContra
            // 
            txtContra.Font = new Font("Segoe UI", 10F);
            txtContra.Location = new Point(850, 38);
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '*';
            txtContra.Size = new Size(180, 34);
            txtContra.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(201, 162, 39);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.FromArgb(11, 37, 69);
            btnRegistrar.Location = new Point(20, 105);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.RadioBorde = 10;
            btnRegistrar.Size = new Size(140, 38);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += BtnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gainsboro;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.FromArgb(11, 37, 69);
            btnLimpiar.Location = new Point(170, 105);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.RadioBorde = 10;
            btnLimpiar.Size = new Size(120, 38);
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
            // RegistroControl
            // 
            AutoScroll = true;
            BackColor = Color.FromArgb(244, 246, 249);
            Controls.Add(lblMensaje);
            Controls.Add(cardFormulario);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTituloModulo);
            Font = new Font("Segoe UI", 9.5F);
            Name = "RegistroControl";
            Padding = new Padding(30, 20, 30, 20);
            Size = new Size(2497, 1209);
            cardFormulario.ResumeLayout(false);
            cardFormulario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloModulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel cardFormulario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtContra;
        private RoundedButton btnRegistrar;
        private RoundedButton btnLimpiar;
        private System.Windows.Forms.Label lblMensaje;
    }
}
