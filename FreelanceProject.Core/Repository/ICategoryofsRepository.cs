using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Repository
{
    public interface ICategoryofsRepository
    {
        public Categoryof GetById(int id);
        public List<Categoryof> GetAll();
        public void delete(int id);
        public void update(Categoryof categoryof);

        public void insert(Categoryof categoryof);
    }
}
