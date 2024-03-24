using Contact_Manager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Contact_Manager.Controllers
{
	public class ContactController : Controller
	{
		public ContactContext context { get; set; }
		public ContactController(ContactContext ctx)
		{
			context = ctx;
		}

		public IActionResult Details(int id)
		{
			var contact = context.Contacts
				.Include(c => c.CategoryId)
				.FirstOrDefault(c => c.ContactId == id);
			return View(contact);
		}

		[HttpGet]
		public IActionResult Add()
		{
			ViewBag.Action = "Add";
			ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();
			return View("Edit", new Contact());
		}
	}
}
