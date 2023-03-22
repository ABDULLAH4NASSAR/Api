using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Repository
{
    public interface IFreelanceraccountofRepository
    {
        public Freelanceraccountof GetById(int id);
        public List<Freelanceraccountof> GetAll();
        public void delete(int id);
        public void update(Freelanceraccountof freelanceraccountof);

        public void insert(Freelanceraccountof freelanceraccountof);
    }
}
