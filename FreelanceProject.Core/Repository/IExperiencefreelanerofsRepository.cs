using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Repository
{
    public interface IExperiencefreelanerofsRepository
    {
        public Experiencefreelanerof GetById(int id);
        public List<Experiencefreelanerof> GetAll();
        public void delete(int id);
        public void update(Experiencefreelanerof experiencefreelanerof);

        public void insert(Experiencefreelanerof experiencefreelanerof);
    }
}
