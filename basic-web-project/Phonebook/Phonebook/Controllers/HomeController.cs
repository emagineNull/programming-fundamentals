using Microsoft.AspNetCore.Mvc;
using Phonebook.Data;
using Phonebook.Data.Models;

namespace Phonebook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // get a list of contacts from the data access method
            var contactsList = DataAccess.Contacts;

            // contactsList.Add(new Contact() { Name = "Alek Rifai", Number = "0888888888"});

            // pass the list of contacts to the View
            return View(contactsList);
        }

        [HttpPost]
        public IActionResult Create(Contact incomingContact)
        {
            // Add the incoming contact to the contacts list.
            DataAccess.Contacts.Add(incomingContact);

            // pass the list of contacts to the View
            return View("Index", DataAccess.Contacts);
        }
    }
}
