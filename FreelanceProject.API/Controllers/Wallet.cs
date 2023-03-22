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
    public class Wallet : ControllerBase
    {
        private readonly IWallettofService wallettofService;
        public Wallet(IWallettofService wallettofService)
        {
            this.wallettofService = wallettofService;
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public Wallettof GetById(int id) { return wallettofService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Wallettof> GetAll() { return wallettofService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { wallettofService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Wallettof wallettof) { wallettofService.update(wallettof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Wallettof wallettof) { wallettofService.insert(wallettof); }
    }
}
