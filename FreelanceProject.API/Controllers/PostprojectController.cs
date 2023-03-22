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
    public class PostprojectController : ControllerBase
    {
        private readonly IPostprojectofService postprojectofService;
        public PostprojectController(IPostprojectofService postprojectofService)
        {
            this.postprojectofService = postprojectofService;
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Postprojectof GetById(int id) { return postprojectofService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Postprojectof> GetAll() { return postprojectofService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { postprojectofService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Postprojectof postprojectof) { postprojectofService.update(postprojectof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Postprojectof postprojectof) { postprojectofService.insert(postprojectof); }
    }
}
