using GymCheck.Mensajes;
using System.Configuration;

namespace Miselaneas
{
	public partial class FConfig : Form
	{
		string servidor;
		string baseDatos;
		string usuario;
		string password;
		public FConfig()
		{
			InitializeComponent();
		}

		private void btnGymFolder_Click(object sender, EventArgs e)
		{
			fBDGymFolder = new FolderBrowserDialog();
			if (fBDGymFolder.ShowDialog() == DialogResult.OK)
			{
				lblFolderDefault.Text = fBDGymFolder.SelectedPath + "\\";
				EscribirConfig("RutaFotos", lblFolderDefault.Text);
				Mensaje.Mostrar("Exito", "Se ha actualizado la carpeta", TipoMensaje.Informacion);
			}
		}

		private void btnBuckUpFolder_Click(object sender, EventArgs e)
		{
			fBDBuckUp = new FolderBrowserDialog();
			if (fBDBuckUp.ShowDialog() == DialogResult.OK)
			{
				lblFolderBuckUp.Text = fBDBuckUp.SelectedPath + "\\";
				EscribirConfig("RutaBuckUp", lblFolderBuckUp.Text);
				Mensaje.Mostrar("Exito", "Se ha actualizado la carpeta de BuckUp", TipoMensaje.Informacion);
			}
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				servidor = txtServidor.Text ?? servidor;
				baseDatos = txtBase.Text ?? baseDatos;
				usuario = txtUsuario.Text ?? usuario;
				password = txtPass.Text ?? password;

				EscribirConfig("Servidor", servidor);
				EscribirConfig("Database", baseDatos);
				EscribirConfig("User", usuario);
				EscribirConfig("Password", password);
				Mensaje.Mostrar("Exito", "Se ha actualizdo la conexión", TipoMensaje.Informacion);
			}
			catch
			{

			}
		}
		private void CargarDatos()
		{
			servidor = ConfigurationManager.AppSettings["Servidor"] ?? string.Empty;
			baseDatos = ConfigurationManager.AppSettings["Database"] ?? string.Empty;
			usuario = ConfigurationManager.AppSettings["User"] ?? string.Empty;
			password = ConfigurationManager.AppSettings["Password"] ?? string.Empty;

			txtServidor.Text = servidor;
			txtBase.Text = baseDatos;
			txtUsuario.Text = usuario;
			txtPass.Text = password;

		}

		private void CargarRutas()
		{
			lblFolderDefault.Text = ConfigurationManager.AppSettings["RutaFotos"];
			lblFolderBuckUp.Text = ConfigurationManager.AppSettings["RutaBuckUp"];
			lblFolderPdf.Text = ConfigurationManager.AppSettings["RutaPdf"];
		}

		private void btnPdfFolder_Click(object sender, EventArgs e)
		{
			fBDPdfFolder = new();
			if (fBDPdfFolder.ShowDialog() == DialogResult.OK)
			{
				lblFolderPdf.Text = fBDPdfFolder.SelectedPath + "\\";
				EscribirConfig("RutaPdf", lblFolderPdf.Text);
				Mensaje.Mostrar("Exito", "Se ha actualizado la carpeta pdf, contacte a su administrador ", TipoMensaje.Informacion);
			}
		}
		private void EscribirConfig(string key, string value)
		{
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			config.AppSettings.Settings[key].Value = value;
			config.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("appSettings");
		}

		private void btnConfigurar_Click(object sender, EventArgs e)
		{
			if (nudPrimero.Value > 0 && nudSegundo.Value > 0 && nudPrimero.Value <= nudSegundo.Value)
			{
				EscribirConfig("HoraReporteM", nudPrimero.Value.ToString());
				EscribirConfig("HoraReporteT", nudSegundo.Value.ToString());
				Mensaje.Mostrar("Exito", "Se ha actualizado la hora de reporte", TipoMensaje.Informacion);
			}
		}

		private void tPHoras_Enter(object sender, EventArgs e)
		{
			string hora = ConfigurationManager.AppSettings["HoraReporteM"] ?? "0";
			string hora2 = ConfigurationManager.AppSettings["HoraReporteT"] ?? "0";
			nudPrimero.Value = Convert.ToInt32(hora);
			nudSegundo.Value = Convert.ToInt32(hora2);
		}

		private void rdbDesarrollo_CheckedChanged(object sender, EventArgs e)
		{
			if (rdbDesarrollo.Checked)
			{
				try
				{
					if (DataBaseSettings("SAIKANO\\SQLEXPRESS", "GymDB", "sa", "2016"))
						Mensaje.Mostrar("Exito", "Se ha actualizdo la conexión a Desarrollo", TipoMensaje.Informacion);
					else Mensaje.Mostrar("Error", "No se ha podido actualizar la conexión", TipoMensaje.Error);
				}
				catch
				{

				}
			}
		}

		private bool DataBaseSettings(string ser, string bas, string use, string pas)
		{
			try
			{
				EscribirConfig("Servidor", ser);
				EscribirConfig("Database", bas);
				EscribirConfig("User", use);
				EscribirConfig("Password", pas);
				return true;
			}
			catch
			{
				return false;
			}
		}

		private void tPCadena_Enter(object sender, EventArgs e)
		{
			CargarDatos();
		}

		private void tPRutas_Enter(object sender, EventArgs e)
		{
			CargarRutas();
		}

		private void rdbPrueba_CheckedChanged(object sender, EventArgs e)
		{
			if (rdbPrueba.Checked)
			{
				try
				{
					if (DataBaseSettings("DESKTOP-H8VLRCJ\\Sqlserver", "GymDBPrueba", "sa", "genius"))
						Mensaje.Mostrar("Exito", "Se ha actualizdo la conexión a Producción", TipoMensaje.Informacion);
					else Mensaje.Mostrar("Error", "No se ha podido actualizar la conexión", TipoMensaje.Error);
				}
				catch
				{

				}
			}
		}

		private void rdbOxigen_CheckedChanged(object sender, EventArgs e)
		{
			if (rdbOxigen.Checked)
			{
				try
				{
					if (DataBaseSettings("DESKTOP-H8VLRCJ\\Sqlserver", "GymDB", "sa", "genius"))
						Mensaje.Mostrar("Exito", "Se ha actualizdo la conexión a Oxigen Gym", TipoMensaje.Informacion);
					else Mensaje.Mostrar("Error", "No se ha podido actualizar la conexión", TipoMensaje.Error);
				}
				catch
				{

				}
			}
		}
	}
}
