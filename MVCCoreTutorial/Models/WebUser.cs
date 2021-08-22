using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreTutorial.Models
{
	public class WebUser
	{

		[Required(ErrorMessage = "The First name is required.")]
		[StringLength(25, ErrorMessage = "The First name cannot be longer than 25 chars.")]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }


		[Required(ErrorMessage = "The Last name is required.")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "The Last name cannot be longer than 50 chars.")]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }


		public List<string> Countries { get; set; }



	}
}
