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
    public class ReviewController : ControllerBase
    {
        private readonly IReviewsofService reviewsofService;
        public ReviewController(IReviewsofService reviewsofService)
        {
            this.reviewsofService = reviewsofService;
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Reviewsof GetById(int id) { return reviewsofService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Reviewsof> GetAll() { return reviewsofService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { reviewsofService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Reviewsof reviewsof) { reviewsofService.update(reviewsof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Reviewsof reviewsof) { reviewsofService.insert(reviewsof); }
    }
}
