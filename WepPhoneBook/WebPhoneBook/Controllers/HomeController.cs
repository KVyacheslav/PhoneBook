using System.Collections.Generic;
using System.Linq;
using WebPhoneBook.Context;
using WebPhoneBook.Data;
using WebPhoneBook.Interfaces;
using WebPhoneBook.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebPhoneBook.Controllers
{
    public class HomeController : Controller
    {
        private IPersonData _personData;

        public HomeController(IPersonData personData)
        {
            _personData = personData;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_personData.GetPeople());
        }

        [HttpGet]
        public ViewResult InfoPerson(int? id)
        {
            return View("InfoPerson", _personData.GetPersonById(id));
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult EditPerson(int? id)
        {
            return View("EditPerson", _personData.GetPersonById(id));
        }

        [HttpPost]
        [ActionName("Edit")]
        public IActionResult EditPersonPost(Person person)
        {
            _personData.EditPerson(person);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ViewResult DeletePerson(int? id)
        {
            return View("DeletePerson", _personData.GetPersonById(id));
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePersonPost(Person person)
        {
            _personData.RemovePerson(person);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize]
        public ViewResult CreatePerson(int? id)
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public IActionResult CreatePerson(Person person)
        {
            _personData.AddPerson(person);
            return RedirectToAction("Index");
        }
    }
}
