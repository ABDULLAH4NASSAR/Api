using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Repository
{
    public interface IReviewsofRepository
    {
        public Reviewsof GetById(int id);
        public List<Reviewsof> GetAll();
        public void delete(int id);
        public void update(Reviewsof reviewsof);

        public void insert(Reviewsof reviewsof);
    }
}
