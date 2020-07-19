using System;

namespace TodoREST
{
	public class TodoItem
	{
		public long id { get; set; }

		public string nombre { get; set; }

		public string apellido { get; set; }
		
		public string sexo { get; set; }
		public DateTime fecha { get; set; }
	}
}
