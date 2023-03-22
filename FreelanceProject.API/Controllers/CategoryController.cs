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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryofsService categoryofsService;
        public CategoryController(ICategoryofsService categoryofsService)
        {
            this.categoryofsService = categoryofsService;
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Categoryof GetById(int id) { return categoryofsService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Categoryof> GetAll() { return categoryofsService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { categoryofsService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Categoryof categoryof) { categoryofsService.update(categoryof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Categoryof categoryof) { categoryofsService.insert(categoryof); }
    }
}
