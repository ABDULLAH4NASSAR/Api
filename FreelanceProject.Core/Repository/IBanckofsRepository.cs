using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Repository
{
    public interface IBanckofsRepository
    {
        public Banckof GetById(int id);
        public Banckof authbank(Banckof banckof);

        public List<Banckof> GetAll();
        public void delete(int id);
        public void update(Banckof banckof);

        public int insert(Banckof banckof);
    }
}
