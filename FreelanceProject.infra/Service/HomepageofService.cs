using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class HomepageofService : IHomepageofService
    {
        private readonly IHomepageofRepository homepageofRepository;
        public HomepageofService(IHomepageofRepository homepageofRepository)
        {
            this.homepageofRepository = homepageofRepository;
        }

        public void delete(int id)
        {
homepageofRepository.delete(id);    
                }

        public List<Homepageof> GetAll()
        {
            return homepageofRepository.GetAll();
        }

        public Homepageof GetById(int id)
        {
            return homepageofRepository.GetById(id);
        }

        public void insert(Homepageof homepageof)
        {
            homepageofRepository.insert(homepageof);
        }

        public void update(Homepageof homepageof)
        {
            homepageofRepository.update(homepageof);
        }
    }
}
