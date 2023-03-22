using FreelanceProject.Core.Data;
using FreelanceProject.Core.Service;
using FreelanceProject.infra.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FreelanceProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactusController : ControllerBase
    {
        private readonly IContactusofsService contactusofsService;
        public ContactusController(IContactusofsService contactusofsService)
        {
            this.contactusofsService = contactusofsService;
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Contactusof GetById(int id) { return contactusofsService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Contactusof> GetAll() { return contactusofsService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { contactusofsService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Contactusof contactusof) { contactusofsService.update(contactusof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Contactusof contactusof) { contactusofsService.insert(contactusof); }
    }
}
