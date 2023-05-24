namespace Customer
{
	partial class FModificarClientes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FModificarClientes));
			label1 = new Label();
			label2 = new Label();
			txtDniAbuscar = new TextBox();
			btnBuscar = new Button();
			tbcCliente = new TabControl();
			tbpDatos = new TabPage();
			label12 = new Label();
			txtDni = new TextBox();
			txtApellido = new TextBox();
			txtNombre = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			tbpContacto = new TabPage();
			txtMail = new TextBox();
			txtTelefono = new TextBox();
			txtDireccion = new TextBox();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			tbpFechas = new TabPage();
			label10 = new Label();
			label9 = new Label();
			dtpInscripcion = new DateTimePicker();
			dtpNacimiento = new DateTimePicker();
			tbpFoto = new TabPage();
			btnGuardarFoto = new Button();
			btnCapturarFoto = new Button();
			btnIniciarCamara = new Button();
			cmbCamaras = new ComboBox();
			pbFoto = new PictureBox();
			pbCamara = new PictureBox();
			tbpRedes = new TabPage();
			btnQuitarRedSocial = new Button();
			ltbUsuariosRedes = new ListBox();
			btnAgregarRedSocial = new Button();
			txtUsuario = new TextBox();
			label14 = new Label();
			label13 = new Label();
			cmbRedesSociales = new ComboBox();
			tbpOtros = new TabPage();
			label11 = new Label();
			txtComentario = new TextBox();
			pnlAceptar = new Panel();
			btnAceptar = new Button();
			lblInfo = new Label();
			tbcCliente.SuspendLayout();
			tbpDatos.SuspendLayout();
			tbpContacto.SuspendLayout();
			tbpFechas.SuspendLayout();
			tbpFoto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbCamara).BeginInit();
			tbpRedes.SuspendLayout();
			tbpOtros.SuspendLayout();
			pnlAceptar.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Georgia", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(16, 9);
			label1.Name = "label1";
			label1.Size = new Size(462, 43);
			label1.TabIndex = 1;
			label1.Text = "Modificar datos del Cliente";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.White;
			label2.Location = new Point(12, 82);
			label2.Name = "label2";
			label2.Size = new Size(199, 38);
			label2.TabIndex = 2;
			label2.Text = "Dni a Buscar";
			// 
			// txtDniAbuscar
			// 
			txtDniAbuscar.BackColor = Color.DarkGray;
			txtDniAbuscar.ForeColor = Color.White;
			txtDniAbuscar.Location = new Point(217, 82);
			txtDniAbuscar.Name = "txtDniAbuscar";
			txtDniAbuscar.Size = new Size(320, 44);
			txtDniAbuscar.TabIndex = 3;
			txtDniAbuscar.TextAlign = HorizontalAlignment.Center;
			txtDniAbuscar.TextChanged += txtDniAbuscar_TextChanged;
			txtDniAbuscar.KeyDown += txtDniAbuscar_KeyDown;
			txtDniAbuscar.KeyPress += txtDniAbuscar_KeyPress;
			// 
			// btnBuscar
			// 
			btnBuscar.BackColor = Color.SteelBlue;
			btnBuscar.ForeColor = Color.White;
			btnBuscar.Location = new Point(563, 75);
			btnBuscar.Name = "btnBuscar";
			btnBuscar.Size = new Size(159, 52);
			btnBuscar.TabIndex = 4;
			btnBuscar.Text = "Buscar";
			btnBuscar.UseVisualStyleBackColor = false;
			btnBuscar.Click += btnBuscar_Click;
			// 
			// tbcCliente
			// 
			tbcCliente.Controls.Add(tbpDatos);
			tbcCliente.Controls.Add(tbpContacto);
			tbcCliente.Controls.Add(tbpFechas);
			tbcCliente.Controls.Add(tbpFoto);
			tbcCliente.Controls.Add(tbpRedes);
			tbcCliente.Controls.Add(tbpOtros);
			tbcCliente.Enabled = false;
			tbcCliente.Location = new Point(12, 133);
			tbcCliente.Name = "tbcCliente";
			tbcCliente.SelectedIndex = 0;
			tbcCliente.Size = new Size(710, 414);
			tbcCliente.TabIndex = 5;
			// 
			// tbpDatos
			// 
			tbpDatos.BackColor = Color.Gray;
			tbpDatos.Controls.Add(label12);
			tbpDatos.Controls.Add(txtDni);
			tbpDatos.Controls.Add(txtApellido);
			tbpDatos.Controls.Add(txtNombre);
			tbpDatos.Controls.Add(label5);
			tbpDatos.Controls.Add(label4);
			tbpDatos.Controls.Add(label3);
			tbpDatos.ForeColor = Color.White;
			tbpDatos.Location = new Point(4, 47);
			tbpDatos.Name = "tbpDatos";
			tbpDatos.Padding = new Padding(3);
			tbpDatos.Size = new Size(702, 363);
			tbpDatos.TabIndex = 0;
			tbpDatos.Text = "Datos";
			tbpDatos.Enter += tbpDatos_Enter;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.BackColor = Color.White;
			label12.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label12.ForeColor = Color.Firebrick;
			label12.Location = new Point(11, 228);
			label12.Name = "label12";
			label12.Size = new Size(513, 18);
			label12.TabIndex = 6;
			label12.Text = "* El DNI debe tener más de 6 dígitos y todos los campos son obligatorios";
			// 
			// txtDni
			// 
			txtDni.BackColor = Color.DarkGray;
			txtDni.ForeColor = Color.White;
			txtDni.Location = new Point(160, 162);
			txtDni.Name = "txtDni";
			txtDni.Size = new Size(307, 44);
			txtDni.TabIndex = 5;
			txtDni.TextAlign = HorizontalAlignment.Center;
			txtDni.TextChanged += txtNombre_TextChanged;
			txtDni.KeyPress += txtDni_KeyPress;
			// 
			// txtApellido
			// 
			txtApellido.BackColor = Color.DarkGray;
			txtApellido.ForeColor = Color.White;
			txtApellido.Location = new Point(160, 104);
			txtApellido.Name = "txtApellido";
			txtApellido.Size = new Size(307, 44);
			txtApellido.TabIndex = 4;
			txtApellido.TextAlign = HorizontalAlignment.Center;
			txtApellido.TextChanged += txtNombre_TextChanged;
			// 
			// txtNombre
			// 
			txtNombre.BackColor = Color.DarkGray;
			txtNombre.ForeColor = Color.White;
			txtNombre.Location = new Point(160, 39);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(307, 44);
			txtNombre.TabIndex = 3;
			txtNombre.TextAlign = HorizontalAlignment.Center;
			txtNombre.TextChanged += txtNombre_TextChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(11, 165);
			label5.Name = "label5";
			label5.Size = new Size(79, 38);
			label5.TabIndex = 2;
			label5.Text = "Dni:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(11, 107);
			label4.Name = "label4";
			label4.Size = new Size(143, 38);
			label4.TabIndex = 1;
			label4.Text = "Apellido:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(11, 42);
			label3.Name = "label3";
			label3.Size = new Size(143, 38);
			label3.TabIndex = 0;
			label3.Text = "Nombre:";
			// 
			// tbpContacto
			// 
			tbpContacto.BackColor = Color.Gray;
			tbpContacto.Controls.Add(txtMail);
			tbpContacto.Controls.Add(txtTelefono);
			tbpContacto.Controls.Add(txtDireccion);
			tbpContacto.Controls.Add(label6);
			tbpContacto.Controls.Add(label7);
			tbpContacto.Controls.Add(label8);
			tbpContacto.ForeColor = Color.White;
			tbpContacto.Location = new Point(4, 24);
			tbpContacto.Name = "tbpContacto";
			tbpContacto.Padding = new Padding(3);
			tbpContacto.Size = new Size(702, 386);
			tbpContacto.TabIndex = 1;
			tbpContacto.Text = "Contacto";
			// 
			// txtMail
			// 
			txtMail.BackColor = Color.DarkGray;
			txtMail.ForeColor = Color.White;
			txtMail.Location = new Point(189, 166);
			txtMail.Name = "txtMail";
			txtMail.Size = new Size(307, 44);
			txtMail.TabIndex = 11;
			txtMail.TextAlign = HorizontalAlignment.Center;
			// 
			// txtTelefono
			// 
			txtTelefono.BackColor = Color.DarkGray;
			txtTelefono.ForeColor = Color.White;
			txtTelefono.Location = new Point(189, 108);
			txtTelefono.Name = "txtTelefono";
			txtTelefono.Size = new Size(307, 44);
			txtTelefono.TabIndex = 10;
			txtTelefono.TextAlign = HorizontalAlignment.Center;
			// 
			// txtDireccion
			// 
			txtDireccion.BackColor = Color.DarkGray;
			txtDireccion.ForeColor = Color.White;
			txtDireccion.Location = new Point(189, 43);
			txtDireccion.Name = "txtDireccion";
			txtDireccion.Size = new Size(307, 44);
			txtDireccion.TabIndex = 9;
			txtDireccion.TextAlign = HorizontalAlignment.Center;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(20, 169);
			label6.Name = "label6";
			label6.Size = new Size(110, 38);
			label6.TabIndex = 8;
			label6.Text = "Email:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(20, 111);
			label7.Name = "label7";
			label7.Size = new Size(149, 38);
			label7.TabIndex = 7;
			label7.Text = "Teléfono:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(20, 46);
			label8.Name = "label8";
			label8.Size = new Size(163, 38);
			label8.TabIndex = 6;
			label8.Text = "Dirección:";
			// 
			// tbpFechas
			// 
			tbpFechas.BackColor = Color.Gray;
			tbpFechas.Controls.Add(label10);
			tbpFechas.Controls.Add(label9);
			tbpFechas.Controls.Add(dtpInscripcion);
			tbpFechas.Controls.Add(dtpNacimiento);
			tbpFechas.Location = new Point(4, 24);
			tbpFechas.Name = "tbpFechas";
			tbpFechas.Padding = new Padding(3);
			tbpFechas.Size = new Size(702, 386);
			tbpFechas.TabIndex = 2;
			tbpFechas.Text = "Fechas";
			tbpFechas.Enter += tbpDatos_Enter;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.ForeColor = Color.White;
			label10.Location = new Point(11, 154);
			label10.Name = "label10";
			label10.Size = new Size(307, 38);
			label10.TabIndex = 3;
			label10.Text = "Fecha de inscripción";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.ForeColor = Color.White;
			label9.Location = new Point(11, 80);
			label9.Name = "label9";
			label9.Size = new Size(314, 38);
			label9.TabIndex = 2;
			label9.Text = "Fecha de Nacimiento";
			// 
			// dtpInscripcion
			// 
			dtpInscripcion.Format = DateTimePickerFormat.Short;
			dtpInscripcion.Location = new Point(413, 149);
			dtpInscripcion.Name = "dtpInscripcion";
			dtpInscripcion.Size = new Size(200, 44);
			dtpInscripcion.TabIndex = 1;
			// 
			// dtpNacimiento
			// 
			dtpNacimiento.Format = DateTimePickerFormat.Short;
			dtpNacimiento.Location = new Point(413, 75);
			dtpNacimiento.Name = "dtpNacimiento";
			dtpNacimiento.Size = new Size(200, 44);
			dtpNacimiento.TabIndex = 0;
			// 
			// tbpFoto
			// 
			tbpFoto.BackColor = Color.Gray;
			tbpFoto.Controls.Add(btnGuardarFoto);
			tbpFoto.Controls.Add(btnCapturarFoto);
			tbpFoto.Controls.Add(btnIniciarCamara);
			tbpFoto.Controls.Add(cmbCamaras);
			tbpFoto.Controls.Add(pbFoto);
			tbpFoto.Controls.Add(pbCamara);
			tbpFoto.Location = new Point(4, 24);
			tbpFoto.Name = "tbpFoto";
			tbpFoto.Padding = new Padding(3);
			tbpFoto.Size = new Size(702, 386);
			tbpFoto.TabIndex = 3;
			tbpFoto.Text = "Foto";
			tbpFoto.Enter += tbpFoto_Enter;
			// 
			// btnGuardarFoto
			// 
			btnGuardarFoto.BackColor = Color.OliveDrab;
			btnGuardarFoto.ForeColor = Color.White;
			btnGuardarFoto.Location = new Point(374, 285);
			btnGuardarFoto.Name = "btnGuardarFoto";
			btnGuardarFoto.Size = new Size(328, 56);
			btnGuardarFoto.TabIndex = 5;
			btnGuardarFoto.Text = "Guardar Foto";
			btnGuardarFoto.UseVisualStyleBackColor = false;
			btnGuardarFoto.Click += btnGuardarFoto_Click;
			// 
			// btnCapturarFoto
			// 
			btnCapturarFoto.BackColor = Color.SteelBlue;
			btnCapturarFoto.ForeColor = Color.White;
			btnCapturarFoto.Location = new Point(368, 215);
			btnCapturarFoto.Name = "btnCapturarFoto";
			btnCapturarFoto.Size = new Size(328, 56);
			btnCapturarFoto.TabIndex = 4;
			btnCapturarFoto.Text = "Cápturar";
			btnCapturarFoto.UseVisualStyleBackColor = false;
			btnCapturarFoto.Click += btnCapturarFoto_Click;
			// 
			// btnIniciarCamara
			// 
			btnIniciarCamara.BackColor = Color.SteelBlue;
			btnIniciarCamara.ForeColor = Color.White;
			btnIniciarCamara.Location = new Point(11, 285);
			btnIniciarCamara.Name = "btnIniciarCamara";
			btnIniciarCamara.Size = new Size(328, 56);
			btnIniciarCamara.TabIndex = 3;
			btnIniciarCamara.Text = "Iniciar Cámara";
			btnIniciarCamara.UseVisualStyleBackColor = false;
			btnIniciarCamara.Click += btnIniciarCamara_Click;
			// 
			// cmbCamaras
			// 
			cmbCamaras.BackColor = Color.DarkGray;
			cmbCamaras.ForeColor = Color.White;
			cmbCamaras.FormattingEnabled = true;
			cmbCamaras.Location = new Point(11, 215);
			cmbCamaras.Name = "cmbCamaras";
			cmbCamaras.Size = new Size(328, 46);
			cmbCamaras.TabIndex = 2;
			// 
			// pbFoto
			// 
			pbFoto.Location = new Point(389, 6);
			pbFoto.Name = "pbFoto";
			pbFoto.Size = new Size(292, 190);
			pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
			pbFoto.TabIndex = 1;
			pbFoto.TabStop = false;
			// 
			// pbCamara
			// 
			pbCamara.Location = new Point(11, 6);
			pbCamara.Name = "pbCamara";
			pbCamara.Size = new Size(292, 190);
			pbCamara.SizeMode = PictureBoxSizeMode.Zoom;
			pbCamara.TabIndex = 0;
			pbCamara.TabStop = false;
			// 
			// tbpRedes
			// 
			tbpRedes.BackColor = Color.Gray;
			tbpRedes.Controls.Add(btnQuitarRedSocial);
			tbpRedes.Controls.Add(ltbUsuariosRedes);
			tbpRedes.Controls.Add(btnAgregarRedSocial);
			tbpRedes.Controls.Add(txtUsuario);
			tbpRedes.Controls.Add(label14);
			tbpRedes.Controls.Add(label13);
			tbpRedes.Controls.Add(cmbRedesSociales);
			tbpRedes.Location = new Point(4, 24);
			tbpRedes.Name = "tbpRedes";
			tbpRedes.Padding = new Padding(3);
			tbpRedes.Size = new Size(702, 386);
			tbpRedes.TabIndex = 4;
			tbpRedes.Text = "Redes";
			tbpRedes.Enter += tbpRedes_Enter;
			// 
			// btnQuitarRedSocial
			// 
			btnQuitarRedSocial.BackColor = Color.IndianRed;
			btnQuitarRedSocial.ForeColor = Color.White;
			btnQuitarRedSocial.Location = new Point(498, 126);
			btnQuitarRedSocial.Name = "btnQuitarRedSocial";
			btnQuitarRedSocial.Size = new Size(137, 96);
			btnQuitarRedSocial.TabIndex = 7;
			btnQuitarRedSocial.Text = "Quitar";
			btnQuitarRedSocial.UseVisualStyleBackColor = false;
			btnQuitarRedSocial.Click += btnQuitarRedSocial_Click;
			// 
			// ltbUsuariosRedes
			// 
			ltbUsuariosRedes.BackColor = Color.DarkGray;
			ltbUsuariosRedes.ForeColor = Color.White;
			ltbUsuariosRedes.FormattingEnabled = true;
			ltbUsuariosRedes.ItemHeight = 38;
			ltbUsuariosRedes.Location = new Point(15, 102);
			ltbUsuariosRedes.Name = "ltbUsuariosRedes";
			ltbUsuariosRedes.Size = new Size(477, 232);
			ltbUsuariosRedes.TabIndex = 6;
			// 
			// btnAgregarRedSocial
			// 
			btnAgregarRedSocial.BackColor = Color.OliveDrab;
			btnAgregarRedSocial.ForeColor = Color.White;
			btnAgregarRedSocial.Location = new Point(498, 3);
			btnAgregarRedSocial.Name = "btnAgregarRedSocial";
			btnAgregarRedSocial.Size = new Size(137, 96);
			btnAgregarRedSocial.TabIndex = 5;
			btnAgregarRedSocial.Text = "Agregar";
			btnAgregarRedSocial.UseVisualStyleBackColor = false;
			btnAgregarRedSocial.Click += btnAgregarRedSocial_Click;
			// 
			// txtUsuario
			// 
			txtUsuario.BackColor = Color.DarkGray;
			txtUsuario.ForeColor = Color.White;
			txtUsuario.Location = new Point(176, 55);
			txtUsuario.Name = "txtUsuario";
			txtUsuario.Size = new Size(316, 44);
			txtUsuario.TabIndex = 4;
			txtUsuario.TextAlign = HorizontalAlignment.Center;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.ForeColor = Color.White;
			label14.Location = new Point(6, 61);
			label14.Name = "label14";
			label14.Size = new Size(129, 38);
			label14.TabIndex = 3;
			label14.Text = "Usuario";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.ForeColor = Color.White;
			label13.Location = new Point(6, 9);
			label13.Name = "label13";
			label13.Size = new Size(164, 38);
			label13.TabIndex = 1;
			label13.Text = "Red Social";
			// 
			// cmbRedesSociales
			// 
			cmbRedesSociales.BackColor = Color.DarkGray;
			cmbRedesSociales.ForeColor = Color.White;
			cmbRedesSociales.FormattingEnabled = true;
			cmbRedesSociales.Location = new Point(176, 3);
			cmbRedesSociales.Name = "cmbRedesSociales";
			cmbRedesSociales.Size = new Size(316, 46);
			cmbRedesSociales.TabIndex = 0;
			// 
			// tbpOtros
			// 
			tbpOtros.BackColor = Color.Gray;
			tbpOtros.Controls.Add(label11);
			tbpOtros.Controls.Add(txtComentario);
			tbpOtros.ForeColor = Color.White;
			tbpOtros.Location = new Point(4, 24);
			tbpOtros.Name = "tbpOtros";
			tbpOtros.Padding = new Padding(3);
			tbpOtros.Size = new Size(702, 386);
			tbpOtros.TabIndex = 5;
			tbpOtros.Text = "Otros";
			tbpOtros.Enter += tbpDatos_Enter;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(50, 29);
			label11.Name = "label11";
			label11.Size = new Size(518, 38);
			label11.TabIndex = 1;
			label11.Text = "Información adicional o importante";
			// 
			// txtComentario
			// 
			txtComentario.BackColor = Color.DarkGray;
			txtComentario.ForeColor = Color.White;
			txtComentario.Location = new Point(30, 70);
			txtComentario.Multiline = true;
			txtComentario.Name = "txtComentario";
			txtComentario.Size = new Size(633, 378);
			txtComentario.TabIndex = 0;
			// 
			// pnlAceptar
			// 
			pnlAceptar.Controls.Add(btnAceptar);
			pnlAceptar.Location = new Point(12, 601);
			pnlAceptar.Name = "pnlAceptar";
			pnlAceptar.Size = new Size(710, 100);
			pnlAceptar.TabIndex = 6;
			// 
			// btnAceptar
			// 
			btnAceptar.BackColor = Color.OliveDrab;
			btnAceptar.ForeColor = Color.White;
			btnAceptar.Location = new Point(3, 3);
			btnAceptar.Name = "btnAceptar";
			btnAceptar.Size = new Size(703, 94);
			btnAceptar.TabIndex = 0;
			btnAceptar.Text = "Aplicar Cambios";
			btnAceptar.UseVisualStyleBackColor = false;
			btnAceptar.Click += btnAceptar_Click;
			// 
			// lblInfo
			// 
			lblInfo.AutoSize = true;
			lblInfo.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
			lblInfo.ForeColor = Color.Khaki;
			lblInfo.Location = new Point(16, 569);
			lblInfo.Name = "lblInfo";
			lblInfo.Size = new Size(625, 29);
			lblInfo.TabIndex = 7;
			lblInfo.Text = "Los cambios serán efectivos cuando haga click en el botón";
			lblInfo.Click += lblInfo_Click;
			// 
			// FModificarClientes
			// 
			AutoScaleDimensions = new SizeF(19F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DimGray;
			ClientSize = new Size(738, 712);
			Controls.Add(lblInfo);
			Controls.Add(pnlAceptar);
			Controls.Add(tbcCliente);
			Controls.Add(btnBuscar);
			Controls.Add(txtDniAbuscar);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(8);
			Name = "FModificarClientes";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Modificar Clientes";
			FormClosed += FModificarClientes_FormClosed;
			tbcCliente.ResumeLayout(false);
			tbpDatos.ResumeLayout(false);
			tbpDatos.PerformLayout();
			tbpContacto.ResumeLayout(false);
			tbpContacto.PerformLayout();
			tbpFechas.ResumeLayout(false);
			tbpFechas.PerformLayout();
			tbpFoto.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
			((System.ComponentModel.ISupportInitialize)pbCamara).EndInit();
			tbpRedes.ResumeLayout(false);
			tbpRedes.PerformLayout();
			tbpOtros.ResumeLayout(false);
			tbpOtros.PerformLayout();
			pnlAceptar.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label1;
		private Label label2;
		private TextBox txtDniAbuscar;
		private Button btnBuscar;
		private TabControl tbcCliente;
		private TabPage tbpDatos;
		private TabPage tbpContacto;
		private Panel pnlAceptar;
		private Button button4;
		private Button btnAceptar;
		private TextBox txtDni;
		private TextBox txtApellido;
		private TextBox txtNombre;
		private Label label5;
		private Label label4;
		private Label label3;
		private TabPage tbpFechas;
		private TabPage tbpFoto;
		private TabPage tbpRedes;
		private TextBox txtMail;
		private TextBox txtTelefono;
		private TextBox txtDireccion;
		private Label label6;
		private Label label7;
		private Label label8;
		private TabPage tbpOtros;
		private Label label10;
		private Label label9;
		private DateTimePicker dtpInscripcion;
		private DateTimePicker dtpNacimiento;
		private Button btnGuardarFoto;
		private Button btnCapturarFoto;
		private Button btnIniciarCamara;
		private ComboBox cmbCamaras;
		private PictureBox pbFoto;
		private PictureBox pbCamara;
		private TextBox txtComentario;
		private Label label11;
		private Label lblInfo;
		private Label label12;
		private Button btnQuitarRedSocial;
		private ListBox ltbUsuariosRedes;
		private Button btnAgregarRedSocial;
		private TextBox txtUsuario;
		private Label label14;
		private Label label13;
		private ComboBox cmbRedesSociales;
	}
}