using FreelanceProject.Core.Data;
using FreelanceProject.Core.Service;
using FreelanceProject.infra.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

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

        [Route("uploadImage")]
        [HttpPost]
        public Freelanceraccountof UploadIMage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("Images", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Freelanceraccountof item = new Freelanceraccountof();
            item.Image = fileName;
            return item;
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
