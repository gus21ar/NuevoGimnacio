using Control;
using Customer;
using GymCheck.Mensajes;
using Miselaneas;
using Servicios.Observer;
using Servicios.Observer.Attendance.Implementacion;
using Servicios.Observer.Implementacion;
using System.Configuration;

namespace GymCheck
{
	public partial class Form1 : Form, IObservador
	{
		DateTime Alarma1, Alarma2;
		#region Monitores
		Screen[] screens = Screen.AllScreens; //Obtiene todos los monitores
		Screen sprincipal, ssecundario;
		bool IsSeconScreen = false;
		#endregion
		public Form1()
		{
			InitializeComponent();
			CPublicador.Instancia.Suscribir(this);
			InicializarTimer();
			DateTime hoy = DateTime.Today;
			int hora1 = Convert.ToInt32(ConfigurationManager.AppSettings["HoraReporteM"] ?? "0");
			int hora2 = Convert.ToInt32(ConfigurationManager.AppSettings["HoraReporteT"] ?? "0");
			if (hora1 > 0 && hora2 > 0)
			{
				if (hora1 < hora2)
				{
					Alarma1 = hoy.AddHours(hora1);
					Alarma2 = hoy.AddHours(hora2);
				}
				else
				{
					Alarma1 = hoy.AddHours(hora2);
					Alarma2 = hoy.AddHours(hora1);
				}
			}
		}

		#region Formularios
		private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			var ventana = new FAyuda();
			ventana.StartPosition = FormStartPosition.Manual;
			ventana.Location = sprincipal.Bounds.Location;
			ventana.ShowDialog();
			this.Visible = true;
		}

		private void agregarRedesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			var ventana = new FRedesAdd();
			ventana.StartPosition = FormStartPosition.Manual;
			ventana.Location = sprincipal.Bounds.Location;
			ventana.ShowDialog();
			this.Visible = true;
		}

		private void agregarMediosDePagoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			var ventana = new FMediosDePago();
			ventana.StartPosition = FormStartPosition.Manual;
			ventana.Location = sprincipal.Bounds.Location;
			ventana.ShowDialog();
			this.Visible = true;
		}

		private void aplicacionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			var ventana = new FConfig();
			ventana.StartPosition = FormStartPosition.Manual;
			ventana.Location = sprincipal.Bounds.Location;
			ventana.ShowDialog();
			this.Visible = true;
		}

		private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			Manager.Iniciar(this,sprincipal);
			this.Visible = true;
		}

		//finalizar region
		#endregion

		private void nuevosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			var ventana = new FPagosRegistro();
			ventana.StartPosition = FormStartPosition.Manual;
			ventana.Location = sprincipal.Bounds.Location;
			ventana.ShowDialog();
			this.Visible = true;
		}

		private void semaforoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FSemaforo.Instacia.StartPosition = FormStartPosition.Manual;
			FSemaforo.Instacia.Location = ssecundario.Bounds.Location;
			FSemaforo.Instacia.Show();
			FSemaforo.Instacia.Activate();

		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			menuPrincipal.Visible = !menuPrincipal.Visible;
		}

		public void Actualizar()
		{
			lblNombre.Text = CPublicador.Instancia.OAcceso.NombreCompleto;
			lblResumen.Text = CPublicador.Instancia.OAcceso.Mensaje;
			panVerCliente.BackColor = CPublicador.Instancia.OAcceso.Semaforo;
			CargarFoto(CPublicador.Instancia.OAcceso.Dni);
			panVerCliente.Visible = true;
		}

		private void CargarFoto(string dni)
		{
			try
			{
				string ruta = ConfigurationManager.AppSettings["RutaFotos"] ?? string.Empty;
				if (dni == "0") pbClienteAcces.Image = Image.FromFile(ruta + "Default.jpg");
				else pbClienteAcces.Image = Image.FromFile(ruta + dni + ".jpg");
			}
			catch { }
		}

		private void btnListo_Click(object sender, EventArgs e)
		{
			panVerCliente.Visible = false;
			CPublicar.Instancia.Notificar();
		}

		private void btnReportes_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			var ventana = new FReportes();
			ventana.StartPosition = FormStartPosition.Manual;
			ventana.Location = sprincipal.Bounds.Location;
			ventana.ShowDialog();
			this.Visible = true;
		}

		private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			var ventana = new FModificarClientes();
			ventana.StartPosition = FormStartPosition.Manual;
			ventana.Location = sprincipal.Bounds.Location;
			ventana.ShowDialog();
			this.Visible = true;
		}

		private void generarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			var ventana = new FReportes();
			ventana.StartPosition = FormStartPosition.Manual;
			ventana.ShowDialog();
			this.Visible = true;
		}

		#region Timer Reportes

		private void InicializarTimer()
		{
			tmrReportes.Interval = 1000;
			tmrReportes.Enabled = true;
			tmrReportes.Start();
			tmrReportes.Tick += TmrReportes_Tick;
		}

		private void TmrReportes_Tick(object? sender, EventArgs e)
		{
			if (DateTime.Now > Alarma1)
			{
				if (DateTime.Now > Alarma2)
				{
					tmrReportes.Stop();
				}
				else
				{
					Alarma1 = Alarma2;
				}

			}
			TimeSpan span = Alarma1.Subtract(DateTime.Now);
			if (span.Hours >= 2)
			{
				tmrReportes.Interval = 7200000;
				return;
			}
			else if (span.Hours >= 1)
			{
				tmrReportes.Interval = 3600000;
				return;
			}
			else if (span.Minutes >= 30)
			{
				tmrReportes.Interval = 1800000;
				return;
			}
			else if (span.Minutes >= 15)
			{
				tmrReportes.Interval = 900000;
				return;
			}
			else if (span.Minutes >= 5)
			{
				tmrReportes.Interval = 300000;
				return;
			}
			else if (span.Minutes >= 1)
			{
				tmrReportes.Interval = 60000;
				return;
			}
			else if (span.Seconds >= 30)
			{
				tmrReportes.Interval = 30000;
				return;
			}
			else if (span.Seconds >= 15)
			{
				tmrReportes.Interval = 15000;
				return;
			}
			else if (span.Seconds >= 7)
			{
				tmrReportes.Interval = 7000;
				return;
			}
			else if (span.Seconds >= 4)
			{
				tmrReportes.Interval = 4000;
				return;
			}
			else if (span.Seconds >= 2)
			{
				tmrReportes.Interval = 2000;
				return;
			}
			else if (span.Seconds >= 1)
			{
				tmrReportes.Interval = 1000;
				return;
			}
			else if (span.Seconds == 0)
			{
				tmrReportes.Interval = 5000;
				CControlPdf.CrearPdfAutomático();
			}
		}



		#endregion

		private void verToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Mensaje.Mostrar("No Implementado", "No se ha implementado esta funcionalidad", TipoMensaje.Informacion);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			IsSeconScreen = screens.Length > 1;
			if(IsSeconScreen)
			{
				sprincipal = Screen.PrimaryScreen;
				foreach(Screen s in screens)
				{
					if(s != sprincipal )
					{
						ssecundario = s;
						this.BackColor = Color.Blue;
						break;
					}
				}
			}
			else
			{
				sprincipal = ssecundario = Screen.PrimaryScreen;
			}
		}
	}
}