using AForge.Video;
using AForge.Video.DirectShow;
using GymCheck.Mensajes;
using GymDBData.Repositorio;
using Servicios.Data;
using Servicios.Dto;
using Servicios.Repositorio;
using System.Configuration;

namespace Customer
{
	public partial class FModificarClientes : Form
	{
		#region Atributos Camara
		private VideoCaptureDevice MiWebCam = null!;
		private FilterInfoCollection MisDispositivos = null!;
		private bool fotoTomada;
		private bool HayCamara;
		#endregion
		#region Atributos Redes
		private List<IUsuariosRedes> listaredes;
		private CRedesRepo redesRepo;

		#endregion
		ICliente OCliente { get; set; }
		IClienteRepo Repo { get; set; }
		bool flagInfo;

		public FModificarClientes()
		{
			InitializeComponent();
			Iniciar();
		}
		#region Metodos
		private void Iniciar()
		{
			OCliente = new CClienteDto();
			Repo = new CClienteRepo();
			Habilitar(false);
			txtDniAbuscar.Focus();
			MiWebCam = new();
			redesRepo = new();
			listaredes = new();
		}

		private void Limpiar()
		{
			txtNombre.Text = "";
			txtApellido.Text = "";
			txtDni.Text = "";
			txtDireccion.Text = "";
			txtTelefono.Text = "";
			txtMail.Text = "";
			txtComentario.Text = "";
		}

		private void Habilitar(bool valor)
		{
			pnlAceptar.Enabled = valor;
			tbcCliente.Enabled = valor;
			HabilitarAceptar();
		}

		private void CargarDatos()
		{
			try
			{
				txtNombre.Text = OCliente.Nombre;
				txtApellido.Text = OCliente.Apellido;
				txtDni.Text = OCliente.Dni;
				txtDireccion.Text = OCliente.Direccion ?? " ";
				txtTelefono.Text = OCliente.Telefono ?? " ";
				txtMail.Text = OCliente.Mail ?? " ";
				txtComentario.Text = OCliente.Comentario ?? " ";
				dtpNacimiento.Value = OCliente.FechaNacimiento ?? DateTime.Now;
				dtpInscripcion.Value = OCliente.FechaInscripcion ?? DateTime.Now;
				listaredes = Repo.Redes(Convert.ToInt32(txtDni.Text));
			}
			catch { }
		}
		private void CargarCliente()
		{
			OCliente.Nombre = txtNombre.Text;
			OCliente.Apellido = txtApellido.Text;
			OCliente.Dni = txtDni.Text;
			OCliente.Direccion = txtDireccion.Text;
			OCliente.Telefono = txtTelefono.Text;
			OCliente.Mail = txtMail.Text;
			OCliente.Comentario = txtComentario.Text;
			OCliente.FechaNacimiento = dtpNacimiento.Value;
			OCliente.FechaInscripcion = dtpInscripcion.Value;
		}

		private void Informar(string msj)
		{
			lblInfo.Text = msj;
		}

		private void HabilitarAceptar()
		{
			btnAceptar.Enabled = (txtNombre.Text.Length > 0 && txtApellido.Text.Length > 0 && txtDni.Text.Length > 6);
		}

		#endregion
		private void btnCerrar_Click(object sender, EventArgs e)
		{
			CerrarCamara();
			this.Close();
		}

		private void txtDniAbuscar_TextChanged(object sender, EventArgs e)
		{
			btnBuscar.Enabled = (txtDniAbuscar.Text.Length > 6);
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			if (Repo.HayClientes(Convert.ToInt32(txtDniAbuscar.Text)))
			{
				OCliente = Repo.Get(txtDniAbuscar.Text);
				Habilitar(true);
				CargarDatos();
			}
			else
			{
				Mensaje.Mostrar("Ups", "No se encontro el cliente", TipoMensaje.Error);
				Limpiar();
				Habilitar(false);
			}
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			CargarCliente();
			if (Repo.Modificar(OCliente)) Mensaje.Mostrar("OK", "Cliente modificado con exito", TipoMensaje.Informacion);
			else Mensaje.Mostrar("Ups", "Error al modificar el cliente", TipoMensaje.Error);
			if(Repo.AgregarRedes(Convert.ToInt32( OCliente.Dni), listaredes))
				Mensaje.Mostrar("OK", "Redes agregadas con exito", TipoMensaje.Informacion);
			else
				Mensaje.Mostrar("Ups", "Error al agregar las redes", TipoMensaje.Error);

			btnCerrar_Click(new(), new());
		}

		private void tbpFoto_Enter(object sender, EventArgs e)
		{
			Informar("La foto solo se guarda con el boton \"Guardar Foto\"");
			flagInfo = true;
			CargarDispositivos();
		}

		private void tbpDatos_Enter(object sender, EventArgs e)
		{
			if (flagInfo)
				Informar("Los cambios serán efectivos cuando haga click en el botón");
			flagInfo = false;

		}

		private void txtNombre_TextChanged(object sender, EventArgs e)
		{
			HabilitarAceptar();
		}

		#region Dni A Buscar
		private void txtDniAbuscar_KeyPress(object sender, KeyPressEventArgs e)
		{
			//GPT
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtDniAbuscar_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnBuscar_Click((object)sender, new EventArgs());
			}
		}

		private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
		{
			//GPT
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
		#endregion
		#region Camara
		private void btnIniciarCamara_Click(object sender, EventArgs e)
		{
			IniciarCamara();
		}

		private void CerrarCamara()
		{
			if ((MiWebCam != null) && (MiWebCam.IsRunning))
			{
				MiWebCam.SignalToStop();
				MiWebCam = null!;
			}
		}
		private void IniciarCamara()
		{
			CerrarCamara();
			MiWebCam = new VideoCaptureDevice(MisDispositivos[cmbCamaras.SelectedIndex].MonikerString);
			MiWebCam.NewFrame += new NewFrameEventHandler(Capturando);
			MiWebCam.Start();
		}

		private void CargarDispositivos()
		{
			MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
			if (MisDispositivos.Count > 0)
			{
				HayCamara = true;
				for (int i = 0; i < MisDispositivos.Count; i++)
				{
					cmbCamaras.Items.Add(MisDispositivos[i].Name.ToString());
				}
				cmbCamaras.Text = MisDispositivos[0].Name.ToString();
			}
			else
			{
				HayCamara = false;
			}
		}

		private void Capturando(object sender, NewFrameEventArgs eventArgs)
		{
			Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
			pbCamara.Image = Imagen;
		}


		private void btnCapturarFoto_Click(object sender, EventArgs e)
		{
			if (MiWebCam != null && MiWebCam.IsRunning)
			{
				Bitmap image = (Bitmap)pbCamara.Image;
				pbFoto.Image = image;
			}
		}

		private void btnGuardarFoto_Click(object sender, EventArgs e)
		{
			GuardarFoto();
		}

		private void GuardarFoto()
		{
			try
			{
				string path = ConfigurationManager.AppSettings["RutaFotos"].ToString() + txtDni.Text + ".Jpg";
				if (pbFoto.Image != null)
				{
					pbFoto.Image.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
				}
				Mensaje.Mostrar("Foto Guardada", "La foto se guardo con exito", TipoMensaje.Informacion);
			}
			catch
			{
				Mensaje.Mostrar("Error", "Error al guardar la foto", TipoMensaje.Error);
			}

		}

		#endregion
		#region Redes Sociales
		private void tbpRedes_Enter(object sender, EventArgs e)
		{
			if (flagInfo)
				Informar("Los cambios serán efectivos cuando haga click en el botón");
			flagInfo = false;
			cmbRedesSociales.DataSource = redesRepo.ObtenerNombresRedes();
			ActualizarRedes();
		}
		private void ActualizarRedes()
		{
			ltbUsuariosRedes.DataSource = null;
			ltbUsuariosRedes.Items.Clear();
			ltbUsuariosRedes.DataSource = listaredes;
			ltbUsuariosRedes.DisplayMember = "Completo";			
		}

		private void btnAgregarRedSocial_Click(object sender, EventArgs e)
		{
			var red = new CUsuariosRedes();
			red.Usuario = txtUsuario.Text;
			red.Red = cmbRedesSociales.Text;
			listaredes.Add(red);
			ActualizarRedes();
			txtUsuario.Text = "";
			txtUsuario.Focus();
		}

		private void btnQuitarRedSocial_Click(object sender, EventArgs e)
		{
			if (ltbUsuariosRedes.SelectedIndex >= 0)
			{
				listaredes.RemoveAt(ltbUsuariosRedes.SelectedIndex);
				ActualizarRedes();
			}
		}
		#endregion
	}
}
