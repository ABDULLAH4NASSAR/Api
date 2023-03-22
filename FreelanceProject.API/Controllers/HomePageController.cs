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
    public class HomePageController : ControllerBase
    {
        private readonly IHomepageofService homepageofService;
        public HomePageController(IHomepageofService homepageofService)
        {
            this.homepageofService = homepageofService;
        }

        [Route("uploadImage")]
        [HttpPost]
        public Homepageof UploadIMage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("Images", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Homepageof item = new Homepageof();
            item.Logourl = fileName;
            return item;
        }

        [Route("uploadImage2")]
        [HttpPost]
        public Homepageof UploadIMage2()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("Images", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Homepageof item = new Homepageof();
            item.Imageurl = fileName;
            return item;
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
