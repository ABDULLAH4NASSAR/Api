using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Service
{
    public interface IEducationfreelanerofsService
    {
        public Educationfreelanerof GetById(int id);
        public List<Educationfreelanerof> GetAll();
        public void delete(int id);
        public void update(Educationfreelanerof educationfreelanerof);

        public void insert(Educationfreelanerof educationfreelanerof);
    }
}
