using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.EntityLayer.Concrete
{
	public class WriterTable
	{
		[Key]
		public int WriterTableId { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }

		public string UserName { get; set; }

		public string Description { get; set; }

		public string ImageUrl { get; set; }

		public string Mail { get; set; }

		public string Password { get; set; }
		public string PasswordConfirm { get; set; }

		public bool Status { get; set; }


		public List<Article> Articles { get; set; }
		//public List<WriterMessage> WriterMessages { get; set; }
	}
}
