using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Service
{
    public interface ITestomonialfreelanceService
    {
        public Testomonialfreelancer GetById(int id);
        public List<Testomonialfreelancer> GetAll();
        public void delete(int id);
        public void update(Testomonialfreelancer testimonialof);

        public void insert(Testomonialfreelancer testimonialof);
    }
}
