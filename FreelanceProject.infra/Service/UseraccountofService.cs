using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class UseraccountofService : IUseraccountofService
    {
        private readonly IUseraccountofRepository useraccountofRepository;
        public UseraccountofService(IUseraccountofRepository useraccountofRepository)
        {
            this.useraccountofRepository = useraccountofRepository;
        }

        public void delete(int id)
        {
            useraccountofRepository.delete(id);
        }

        public List<Useraccountof> GetAll()
        {
            return useraccountofRepository.GetAll();
        }

        public Useraccountof GetById(int id)
        {
            return useraccountofRepository.GetById(id);
        }

        public void insert(Useraccountof useraccountof)
        {
            useraccountofRepository.insert(useraccountof);
        }

        public void update(Useraccountof useraccountof)
        {
            useraccountofRepository.update(useraccountof);
        }
    }
}
