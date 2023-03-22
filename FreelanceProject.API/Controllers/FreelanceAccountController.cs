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
    public class FreelanceAccountController : ControllerBase
    {
        private readonly IFreelanceraccountofService freelanceraccountofService;
        public FreelanceAccountController(IFreelanceraccountofService freelanceraccountofService)
        {
            this.freelanceraccountofService = freelanceraccountofService;
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Freelanceraccountof GetById(int id) { return freelanceraccountofService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Freelanceraccountof> GetAll() { return freelanceraccountofService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { freelanceraccountofService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Freelanceraccountof freelanceraccountof) { freelanceraccountofService.update(freelanceraccountof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Freelanceraccountof freelanceraccountof) { freelanceraccountofService.insert(freelanceraccountof); }
    }
}
