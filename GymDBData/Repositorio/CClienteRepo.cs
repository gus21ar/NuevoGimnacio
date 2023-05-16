using Servicios.Data;
using Servicios.Repositorio;
using GymDBData.Mapeadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymDBData.Entidades;
using Servicios.Dto;

namespace GymDBData.Repositorio
{
	public class CClienteRepo : IClienteRepo
	{
		public bool Agregar(ICliente cliente)
		{
			try
			{
				using (var db = new GymDbContext())
				{
					var clienteNuevo = new Cliente();
					ClienteMaper.Map(cliente, clienteNuevo);
					db.Clientes.Add(clienteNuevo);
					db.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool HayClientes(int dni)
		{
			bool hayClientes = false;
			try
			{
				using (var db = new GymDbContext())
				{
					var cliente = db.Clientes.Where(c => c.Dni == dni.ToString()).FirstOrDefault();					
						hayClientes = cliente != null;					
				}
			}
			catch
			{
				hayClientes = false;
			}
			return hayClientes;
		}

		public int ObtenerIdCliente(int dni)
		{
			int idCliente = 0;
			using (var db = new GymDbContext())
			{
				var cliente = db.Clientes.Where(c => c.Dni == dni.ToString()).FirstOrDefault();
				if (cliente != null)
				{
					idCliente = cliente.Id;
				}
				
			}
			return idCliente;
		}

		public string ObtenerNombreCompleto(int id)
		{
			string nombreCompleto = "";
			using (var db = new GymDbContext())
			{
				var cliente = db.Clientes.Where(c => c.Id == id).FirstOrDefault();
				if (cliente != null)
				{
					nombreCompleto = cliente.Nombre + " " + cliente.Apellido;
				}
			}
			return nombreCompleto;
		}

		public bool AgregarRedes(int dni, List<IUsuariosRedes> listaRedes)
		{
			bool respuesta = false;
			try
			{
				using (var db = new GymDbContext())
				{
					var cliente = db.Clientes.Where(c => c.Dni == dni.ToString()).FirstOrDefault();
					if (cliente != null)
					{
						foreach (var red in listaRedes)
						{
							var redNueva = new UsuarioRedCliente();
							redNueva.IdCliente = cliente.Id;
							redNueva.IdRed = db.RedesSociales.First(x => x.NombreRed == red.Red).Id;
							redNueva.Usuario = red.Usuario;
							db.UsuarioRedClientes.Add(redNueva);
						}
						db.SaveChanges();
						return true;
					}					
				}
			}
			catch { }
			return respuesta;
		}

		public ICliente Get(string dni)
		{
			CClienteDto oClienteDto = new();
			using (var db = new GymDbContext())
			{ 
				var cliente = db.Clientes.Where(c => c.Dni == dni).FirstOrDefault();
				if (cliente != null) ClienteMaper.Map(cliente, oClienteDto);				
			}
			return oClienteDto;

		}

		public bool Modificar(ICliente cliente)
		{
			try
			{
				using (var db = new GymDbContext())
				{
					var clienteNuevo = db.Clientes.Where(c => c.Id == cliente.Id).FirstOrDefault();
					if (clienteNuevo == null) return false;
					ClienteMaper.Map(cliente, clienteNuevo);
					db.Clientes.Update(clienteNuevo);
					db.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		public List<IUsuariosRedes> Redes(int dni)
		{
			List<IUsuariosRedes> listaRedes = new List<IUsuariosRedes>();
			try 
			{
				using (var db = new GymDbContext())
				{
					var cliente = db.Clientes.Where(c => c.Dni == dni.ToString()).FirstOrDefault();
					if (cliente != null)
					{
						var redes = db.UsuarioRedClientes.Where(c => c.IdCliente == cliente.Id).ToList();
						foreach (var red in redes)
						{
							var nombre = db.RedesSociales.First(x => x.Id == red.IdRed).NombreRed;
							var Usuario = red.Usuario??" ";
							var redNueva = new CUsuariosRedes(nombre,Usuario);
							listaRedes.Add(redNueva);
						}
					}
				}
			}
			catch
			{

			}

			return listaRedes;
		}
	}
}

