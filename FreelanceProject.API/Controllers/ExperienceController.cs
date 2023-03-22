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
    public class ExperienceController : ControllerBase
    {
        private readonly IExperiencefreelanerofsService experiencefreelanerofsService;
        public ExperienceController(IExperiencefreelanerofsService experiencefreelanerofsService)
        {
            this.experiencefreelanerofsService = experiencefreelanerofsService;
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Experiencefreelanerof GetById(int id) { return experiencefreelanerofsService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Experiencefreelanerof> GetAll() { return experiencefreelanerofsService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { experiencefreelanerofsService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Experiencefreelanerof experiencefreelanerof) { experiencefreelanerofsService.update(experiencefreelanerof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Experiencefreelanerof experiencefreelanerof) { experiencefreelanerofsService.insert(experiencefreelanerof); }
    }
}
