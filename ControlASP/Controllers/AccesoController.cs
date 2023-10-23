using ControlASP.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace ControlASP.Controllers
{
    public class AccesoController : Controller
    {
        private readonly IConfiguration _configuration;
        static string connectionString;

        public AccesoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Login()
        {
            // Accede a la cadena de conexión desde appsettings.json
            connectionString = _configuration.GetConnectionString("DefaultConnection");

            return View();
        }
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(usuarioModel oUsuario)
        {
            bool registrado;
            string mensaje;

            if (oUsuario.Clave == oUsuario.ConfirmarClave) //Validamos que en el registro, haya indicado la contraseña 2 veces
            {
                oUsuario.Clave = ConvertirSha256(oUsuario.Clave);   //Encriptamos la contraseña indicada con SHA256
            }
            else
            {
                ViewData["Mensaje"] = "Las contraseñas no coinciden";  //Las ViewData permiten enviar datos desdel Controlador hacia nuestra vista
                return View();
            }

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.sp_RegistrarUsuario", cn); //Llamamos al procedimiento almacenado de Registrar
                cmd.Parameters.AddWithValue("Correo", oUsuario.Correo); //Enviamos parametro al SP de Correo
                cmd.Parameters.AddWithValue("Clave", oUsuario.Clave); //Enviamos parametro al SP de Clave

                cmd.Parameters.Add("Registrado", sqlDbType: SqlDbType.Bit).Direction = ParameterDirection.Output; //Preparamos la recepcion de los parametros del SP 0 o 1
                cmd.Parameters.Add("Mensaje", sqlDbType: SqlDbType.VarChar, 100).Direction = ParameterDirection.Output; //Preparamos la recepcion de los parametros del SP 'Mensaje'
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open(); //Abrimos conexión

                cmd.ExecuteNonQuery(); //Ejecutamos comando

                registrado = Convert.ToBoolean(cmd.Parameters["Registrado"].Value);
                mensaje = cmd.Parameters["Mensaje"].Value.ToString();

            }
            ViewData["Mensaje"] = mensaje;

            if (registrado)
            {

                return RedirectToAction("Login", "Acceso");
            }
            else
            {
                return View();
            }

        }
        [HttpPost]
        public IActionResult Login(usuarioModel oUsuario)
        {
			connectionString = _configuration.GetConnectionString("DefaultConnection");
			oUsuario.Clave = ConvertirSha256(oUsuario.Clave);

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.sp_ValidarUsuario", cn); //Llamamos al procedimiento almacenado de Validar
                cmd.Parameters.AddWithValue("Correo", oUsuario.Correo); //Enviamos parametro al SP de Correo
                cmd.Parameters.AddWithValue("Clave", oUsuario.Clave); //Enviamos parametro al SP de Clave

                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open(); //Abrimos conexión

                oUsuario.Id = Convert.ToInt32(cmd.ExecuteScalar().ToString()); //Esté método sólo nos va a leer la primera fila y la primera columna, establecemos el ID del usuario
            }
            if (oUsuario.Id != 0)
            {
				HttpContext.Session.SetString("UsuarioId", oUsuario.Id.ToString());

				return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewData["Mensaje"] = "usuario no encontrado";
            }
            return View();
        }

        public static string ConvertirSha256(string texto)
        {
            StringBuilder sb = new StringBuilder();
            using (SHA256 hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(texto));

                foreach (byte b in result)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

    }
}

