using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelockProject.BusinessLayer.Abstract;
using RelockProject.EntityLayer.Concrete;
using System;

namespace RelockWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost]
        public IActionResult AddMessage(Contact contact)
        {
            contact.Date = Convert.ToDateTime(DateTime.Now.ToString());
            _contactService.TInsert(contact);
            return Ok();
        }
    }
}
