using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class TestimonialofService : ITestimonialofService
    {
        private readonly ITestimonialofRepository testimonialofRepository;
        public TestimonialofService(ITestimonialofRepository testimonialofRepository)
        {
            this.testimonialofRepository = testimonialofRepository;
        }

        public void delete(int id)
        {
            testimonialofRepository.delete(id);
        }

        public List<Testimonialof> GetAll()
        {
           return testimonialofRepository.GetAll();
        }

        public Testimonialof GetById(int id)
        {
            return testimonialofRepository.GetById(id);
        }

        public void insert(Testimonialof testimonialof)
        {
            testimonialofRepository.insert(testimonialof);
        }

        public void update(Testimonialof testimonialof)
        {
            testimonialofRepository.update(testimonialof);
        }
    }
}
