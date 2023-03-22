using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Repository
{
    public interface IEducationfreelanerofsRepository
    {
        public Educationfreelanerof GetById(int id);
        public List<Educationfreelanerof> GetAll();
        public void delete(int id);
        public void update(Educationfreelanerof educationfreelanerof);

        public void insert(Educationfreelanerof educationfreelanerof);
    }
}
