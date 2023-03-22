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
    public class TestomonialfreelancerController : ControllerBase
    {
        private readonly ITestomonialfreelanceService testomonialfreelanceService;
        public TestomonialfreelancerController(ITestomonialfreelanceService testomonialfreelanceService)
        {
            this.testomonialfreelanceService = testomonialfreelanceService;
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public Testomonialfreelancer GetById(int id) { return testomonialfreelanceService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Testomonialfreelancer> GetAll() { return testomonialfreelanceService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { testomonialfreelanceService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Testomonialfreelancer testomonialfreelancer) { testomonialfreelanceService.update(testomonialfreelancer); }
        [HttpPost]
        [Route("insert")]
        public void insert(Testomonialfreelancer testomonialfreelancer) { testomonialfreelanceService.insert(testomonialfreelancer); }
    }
}
