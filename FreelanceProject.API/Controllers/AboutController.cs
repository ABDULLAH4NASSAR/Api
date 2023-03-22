using FreelanceProject.Core.Data;
using FreelanceProject.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

namespace FreelanceProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutusofsService aboutusofsService;
        public AboutController(IAboutusofsService aboutusofsService)
        {
            this.aboutusofsService = aboutusofsService;
        }

        [Route("uploadImage")]
        [HttpPost]
        public Aboutusof UploadIMage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("Images", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Aboutusof item = new Aboutusof();
            item.Imageurl = fileName;
            return item;
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Aboutusof GetById(int id) { return aboutusofsService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Aboutusof> GetAll() { return aboutusofsService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { aboutusofsService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Aboutusof aboutusof) { aboutusofsService.update(aboutusof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Aboutusof aboutusof) { aboutusofsService.insert(aboutusof); }
    }
}
