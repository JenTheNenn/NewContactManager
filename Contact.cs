using System.ComponentModel.DataAnnotations;

namespace Contact_Manager.Models
{
	public class Contact
	{

		public int ContactId { get; set; }

		[Required(ErrorMessage = "Please enter a first name.")]
		public string Firstname { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please enter a lasst name.")]
		public string Lastname { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please enter a phone number.")]
		public string Phone { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please enter an email.")]
		public string Email { get; set; } = string.Empty;

		[Range(1, int.MaxValue, ErrorMessage = "Please select a catagory.")]
		public int CategoryId { get; set; }

		public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}
