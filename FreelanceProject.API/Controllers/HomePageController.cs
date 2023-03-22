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
    public class HomePageController : ControllerBase
    {
        private readonly IHomepageofService homepageofService;
        public HomePageController(IHomepageofService homepageofService)
        {
            this.homepageofService = homepageofService;
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Homepageof GetById(int id) { return homepageofService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Homepageof> GetAll() { return homepageofService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { homepageofService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Homepageof homepageof) { homepageofService.update(homepageof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Homepageof homepageof) { homepageofService.insert(homepageof); }
    }
}
