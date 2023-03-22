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
    public class UsersController : ControllerBase
    {
        private readonly IUseraccountofService useraccountofService;
        public UsersController(IUseraccountofService useraccountofService)
        {
            this.useraccountofService = useraccountofService;
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Useraccountof GetById(int id) { return useraccountofService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Useraccountof> GetAll() { return useraccountofService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { useraccountofService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Useraccountof useraccountof) { useraccountofService.update(useraccountof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Useraccountof useraccountof) { useraccountofService.insert(useraccountof); }
    }
}
