using Contact_Manager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Contact_Manager.Controllers
{
	public class HomeController : Controller
	{


		public IActionResult Delete()
		{
			return View();
		}

		public IActionResult Details()
		{
			return View();
		}

		public IActionResult Edit()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
		public IActionResult Index()
		{
			var contacts = GetContacts();
			return View(contacts);
		}
		private List<Contact> GetContacts()
		{
			var contacts = new List<Contact>
			{
				new Contact {Firstname = "Jen", Lastname = "Perry", Email = "JLPerry121410@gmail.com"},
				new Contact {Firstname = "Chris", Lastname = "Zee", Email = "N/A"},
				new Contact {Firstname = "Winnie The", Lastname = "Pooh", Email = "None"},

			};
			return contacts;
        }
	}
}
