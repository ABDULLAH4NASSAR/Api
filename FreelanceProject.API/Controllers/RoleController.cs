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
    public class RoleController : ControllerBase
    {
        private readonly IRoleofService roleofservice;
        public RoleController(IRoleofService roleofservice)
        {
            this.roleofservice = roleofservice;
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public Roleof GetById(int id) { return roleofservice.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Roleof> GetAll() { return roleofservice.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { roleofservice.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Roleof roleof) { roleofservice.update(roleof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Roleof roleof) { roleofservice.insert(roleof); }
    }
}
