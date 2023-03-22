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
    public class SliderController : ControllerBase
    {
        private readonly ISliderofService sliderofservice;  
        public SliderController(ISliderofService sliderofservice)
        {
            this.sliderofservice = sliderofservice;
        }
       
        [HttpGet]
        [Route("GetAll")]
        public List<Sliderof> GetAll() { return sliderofservice.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { sliderofservice.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Sliderof sliderof) { sliderofservice.update(sliderof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Sliderof sliderof) { sliderofservice.insert(sliderof); }
    }
}
