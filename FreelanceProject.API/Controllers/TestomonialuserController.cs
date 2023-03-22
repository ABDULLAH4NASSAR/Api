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
    public class TestomonialuserController : ControllerBase
    {
        private readonly ITestimonialofService testimonialofService;
        public TestomonialuserController(ITestimonialofService testimonialofService)
        {
            this.testimonialofService = testimonialofService;
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public Testimonialof GetById(int id) { return testimonialofService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Testimonialof> GetAll() { return testimonialofService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { testimonialofService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Testimonialof testimonialof) { testimonialofService.update(testimonialof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Testimonialof testimonialof) { testimonialofService.insert(testimonialof); }
    }
}
