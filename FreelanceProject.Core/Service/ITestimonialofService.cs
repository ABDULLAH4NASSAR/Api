using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Service
{
    public interface ITestimonialofService
    {
        public Testimonialof GetById(int id);
        public List<Testimonialof> GetAll();
        public void delete(int id);
        public void update(Testimonialof testimonialof);

        public void insert(Testimonialof testimonialof);
    }
}
