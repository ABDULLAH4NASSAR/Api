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
    public class PublicationController : ControllerBase
    {
        private readonly IPublicationsfreelanerofService publicationsfreelanerofService;
        public PublicationController(IPublicationsfreelanerofService publicationsfreelanerofService)
        {
            this.publicationsfreelanerofService = publicationsfreelanerofService;
        }


        [HttpGet]
        [Route("GetById/{id}")]
        public Publicationsfreelanerof GetById(int id) { return publicationsfreelanerofService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Publicationsfreelanerof> GetAll() { return publicationsfreelanerofService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { publicationsfreelanerofService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Publicationsfreelanerof publicationsfreelanerof) { publicationsfreelanerofService.update(publicationsfreelanerof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Publicationsfreelanerof publicationsfreelanerof) { publicationsfreelanerofService.insert(publicationsfreelanerof); }
    }
}
