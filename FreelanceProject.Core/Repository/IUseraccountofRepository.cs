using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Repository
{
    public interface IUseraccountofRepository
    {
        public Useraccountof GetById(int id);
        public List<Useraccountof> GetAll();
        public void delete(int id);
        public void update(Useraccountof useraccountof);

        public void insert(Useraccountof useraccountof);
    }
}
