using FreelanceProject.Core.Data;
using FreelanceProject.Core.Service;
using FreelanceProject.infra.Repository;
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
        [HttpPost]
        [Route("authbank/{salary}")]
        public Banckof authbank(Banckof banckof,int salary)
        {
            var x= banckofsService.authbank(banckof);

            if(x != null) 
            {
                
                x.Amount = x.Amount - salary;
                var admin =banckofsService.GetById(1);
                admin.Amount = admin.Amount + salary;
                banckofsService.update(admin);


                banckofsService.update(x);
                return x;
            
            }

            return null;
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
        public int insert(Banckof banckof) {return banckofsService.insert(banckof); }
    }
}
