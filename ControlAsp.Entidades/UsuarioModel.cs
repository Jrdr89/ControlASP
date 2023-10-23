using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlASP.Entidades
{

	[Table("usuario")]
	public class usuarioModel
	{
		[Key]
		[Column("IdUsuario")]
		public int Id { get; set; }

		[Column("Correo")]
		public string Correo { get; set; }

		[Column("Clave")]
		public string Clave { get; set; }

		[NotMapped] public string ConfirmarClave { get; set; }
	}

}
