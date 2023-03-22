using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Service
{
    public interface IUseraccountofService
    {
        public Useraccountof GetById(int id);
        public List<Useraccountof> GetAll();
        public void delete(int id);
        public void update(Useraccountof useraccountof);

        public void insert(Useraccountof useraccountof);
    }
}
