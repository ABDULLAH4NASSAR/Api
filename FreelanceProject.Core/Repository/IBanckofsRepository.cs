using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Repository
{
    public interface IBanckofsRepository
    {
        public Banckof GetById(int id);
        public List<Banckof> GetAll();
        public void delete(int id);
        public void update(Banckof banckof);

        public void insert(Banckof banckof);
    }
}
