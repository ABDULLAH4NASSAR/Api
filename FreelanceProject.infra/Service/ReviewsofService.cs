using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class ReviewsofService : IReviewsofService
    {
        private readonly IReviewsofRepository reviewsofRepository;
        public ReviewsofService(IReviewsofRepository reviewsofRepository)
        {
            this.reviewsofRepository = reviewsofRepository;
        }

        public void delete(int id)
        {
            reviewsofRepository.delete(id);
        }

        public List<Reviewsof> GetAll()
        {
            return reviewsofRepository.GetAll();    
        }

        public Reviewsof GetById(int id)
        {
            return reviewsofRepository.GetById(id);
        }

        public void insert(Reviewsof reviewsof)
        {
            reviewsofRepository.insert(reviewsof);
        }

        public void update(Reviewsof reviewsof)
        {
            reviewsofRepository.update(reviewsof);
        }
    }
}
