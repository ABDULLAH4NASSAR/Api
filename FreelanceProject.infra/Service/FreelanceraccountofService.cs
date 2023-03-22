using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class FreelanceraccountofService : IFreelanceraccountofService
    {
        private readonly IFreelanceraccountofRepository freelanceraccountofRepository;
        public FreelanceraccountofService(IFreelanceraccountofRepository freelanceraccountofRepository)
        {
            this.freelanceraccountofRepository = freelanceraccountofRepository;
        }

        public void delete(int id)
        { 
            freelanceraccountofRepository.delete(id);
        }

        public List<Freelanceraccountof> GetAll()
        {
            return freelanceraccountofRepository.GetAll();
        }

        public Freelanceraccountof GetById(int id)
        {
          return  freelanceraccountofRepository.GetById(id);
        }

        public void insert(Freelanceraccountof freelanceraccountof)
        {
            freelanceraccountofRepository.insert(freelanceraccountof);
        }

        public void update(Freelanceraccountof freelanceraccountof)
        {
            freelanceraccountofRepository.update(freelanceraccountof);
        }
    }
}
