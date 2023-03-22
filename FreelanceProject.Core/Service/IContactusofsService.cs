using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Service
{
    public interface IContactusofsService
    {
        public Contactusof GetById(int id);
        public List<Contactusof> GetAll();
        public void delete(int id);
        public void update(Contactusof contactusof);

        public void insert(Contactusof contactusof);
    }
}
