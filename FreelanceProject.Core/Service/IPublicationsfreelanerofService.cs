using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Service
{
    public interface IPublicationsfreelanerofService
    {
        public Publicationsfreelanerof GetById(int id);
        public List<Publicationsfreelanerof> GetAll();
        public void delete(int id);
        public void update(Publicationsfreelanerof publicationsfreelanerof);

        public void insert(Publicationsfreelanerof publicationsfreelanerof);
    }
}
