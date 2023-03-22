using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class TestomonialfreelanceService : ITestomonialfreelanceService
    {
        private readonly ITestomonialfreelnce testomonialfreelnce;
        public TestomonialfreelanceService(ITestomonialfreelnce testomonialfreelnce)
        {
            this.testomonialfreelnce = testomonialfreelnce;
        }

        public void delete(int id)
        {
            testomonialfreelnce.delete(id);
        }

        public List<Testomonialfreelancer> GetAll()
        {
            return testomonialfreelnce.GetAll();
        }

        public Testomonialfreelancer GetById(int id)
        {
            return testomonialfreelnce.GetById(id);
        }

        public void insert(Testomonialfreelancer testimonialof)
        {
            testomonialfreelnce.insert(testimonialof);
        }

        public void update(Testomonialfreelancer testimonialof)
        {
            testomonialfreelnce.update(testimonialof);
        }
    }
}
