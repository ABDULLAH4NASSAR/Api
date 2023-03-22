using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Service
{
    public interface IPostprojectofService
    {
        public Postprojectof GetById(int id);
        public List<Postprojectof> GetAll();
        public void delete(int id);
        public void update(Postprojectof postprojectof);

        public void insert(Postprojectof postprojectof);
    }
}
