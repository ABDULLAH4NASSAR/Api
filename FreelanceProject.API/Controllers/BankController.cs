using FreelanceProject.Core.Data;
using FreelanceProject.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FreelanceProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBanckofsService banckofsService;
        public BankController(IBanckofsService banckofsService)
        {
            this.banckofsService = banckofsService;
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Banckof GetById(int id) { return banckofsService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Banckof> GetAll() { return banckofsService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { banckofsService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Banckof banckof) { banckofsService.update(banckof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Banckof banckof) { banckofsService.insert(banckof); }
    }
}
