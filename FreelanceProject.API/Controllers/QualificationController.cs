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
    public class QualificationController : ControllerBase
    {
        private readonly IQualificationsfreelanerofService qualificationsfreelanerofService;
        public QualificationController(IQualificationsfreelanerofService qualificationsfreelanerofService)
        {
            this.qualificationsfreelanerofService = qualificationsfreelanerofService;
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Qualificationsfreelanerof GetById(int id) { return qualificationsfreelanerofService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Qualificationsfreelanerof> GetAll() { return qualificationsfreelanerofService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { qualificationsfreelanerofService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Qualificationsfreelanerof qualificationsfreelanerof) { qualificationsfreelanerofService.update(qualificationsfreelanerof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Qualificationsfreelanerof qualificationsfreelanerof) { qualificationsfreelanerofService.insert(qualificationsfreelanerof); }
    }
}
