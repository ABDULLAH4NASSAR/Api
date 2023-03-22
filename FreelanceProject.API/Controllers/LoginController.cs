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
    public class LoginController : ControllerBase
    {
        private readonly ILoginofService loginofService;
        public LoginController(ILoginofService loginofService)
        {
            this.loginofService = loginofService;
        }

        [HttpPost]
        [Route("Auth")]
        public IActionResult Auth([FromBody]Loginof loginof)
        {
            var token = loginofService.Auth(loginof);
            if (token == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(token);
            }
        }


        [HttpGet]
        [Route("GetById/{id}")]
        public Loginof GetById(int id) { return loginofService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Loginof> GetAll() { return loginofService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { loginofService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Loginof loginof) { loginofService.update(loginof); }
        [HttpPost]
        [Route("insert")]
        public int insert(Loginof loginof) {  return loginofService.insert(loginof); }
    }
}
