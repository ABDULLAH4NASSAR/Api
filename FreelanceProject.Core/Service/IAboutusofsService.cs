using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Service
{
    public interface IAboutusofsService
    {
        public Aboutusof GetById(int id);
        public List<Aboutusof> GetAll();
        public void delete(int id);
        public void update(Aboutusof aboutusof);

        public void insert(Aboutusof aboutusof);
    }
}
