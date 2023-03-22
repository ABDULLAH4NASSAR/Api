using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class PublicationsfreelanerofService : IPublicationsfreelanerofService
    {
        private readonly IPublicationsfreelanerofRepository publicationsfreelanerofRepository;
        public PublicationsfreelanerofService(IPublicationsfreelanerofRepository publicationsfreelanerofRepository)
        {
            this.publicationsfreelanerofRepository = publicationsfreelanerofRepository;
        }

        public void delete(int id)
        {
            publicationsfreelanerofRepository.delete(id);
        }

        public List<Publicationsfreelanerof> GetAll()
        {
           return publicationsfreelanerofRepository.GetAll();
        }

        public Publicationsfreelanerof GetById(int id)
        {
            return publicationsfreelanerofRepository.GetById(id);
        }

        public void insert(Publicationsfreelanerof publicationsfreelanerof)
        {
            publicationsfreelanerofRepository.insert(publicationsfreelanerof);
        }

        public void update(Publicationsfreelanerof publicationsfreelanerof)
        {
            publicationsfreelanerofRepository.update(publicationsfreelanerof);
        }
    }
}
