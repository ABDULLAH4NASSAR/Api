using FreelanceProject.Core.Data;
using FreelanceProject.Core.Service;
using FreelanceProject.infra.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FreelanceProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUseraccountofService useraccountofService;
        public UsersController(IUseraccountofService useraccountofService)
        {
            this.useraccountofService = useraccountofService;
        }
        [Route("uploadImage")]
        [HttpPost]
        public Useraccountof UploadIMage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("Images", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Useraccountof item = new Useraccountof();
            item.Image = fileName;
            return item;
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Useraccountof GetById(int id) { return useraccountofService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Useraccountof> GetAll() {
            return useraccountofService.GetAll();
        
        
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { useraccountofService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Useraccountof useraccountof) { useraccountofService.update(useraccountof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Useraccountof useraccountof) { useraccountofService.insert(useraccountof); }
    }
}
