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
    public class EducationController : ControllerBase
    {
        private readonly IEducationfreelanerofsService educationfreelanerofsService;
        public EducationController(IEducationfreelanerofsService educationfreelanerofsService)
        {
            this.educationfreelanerofsService = educationfreelanerofsService;
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Educationfreelanerof GetById(int id) { return educationfreelanerofsService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Educationfreelanerof> GetAll() { return educationfreelanerofsService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { educationfreelanerofsService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Educationfreelanerof educationfreelanerof) { educationfreelanerofsService.update(educationfreelanerof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Educationfreelanerof educationfreelanerof) { educationfreelanerofsService.insert(educationfreelanerof); }
    }
}
