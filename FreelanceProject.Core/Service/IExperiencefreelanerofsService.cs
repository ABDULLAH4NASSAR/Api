using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Service
{
    public interface IExperiencefreelanerofsService
    {
        public Experiencefreelanerof GetById(int id);
        public List<Experiencefreelanerof> GetAll();
        public void delete(int id);
        public void update(Experiencefreelanerof experiencefreelanerof);

        public void insert(Experiencefreelanerof experiencefreelanerof);
    }
}
