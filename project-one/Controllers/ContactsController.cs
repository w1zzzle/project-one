using Microsoft.AspNetCore.Mvc;
using project_one.Models;

namespace project_one.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index() // contacts
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Contact contact) 
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Index");
        }
    }
}
