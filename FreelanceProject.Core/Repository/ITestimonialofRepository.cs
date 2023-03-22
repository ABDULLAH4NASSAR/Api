using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Repository
{
    public interface ITestimonialofRepository
    {
        public Testimonialof GetById(int id);
        public List<Testimonialof> GetAll();
        public void delete(int id);
        public void update(Testimonialof testimonialof);

        public void insert(Testimonialof testimonialof);
    }
}
