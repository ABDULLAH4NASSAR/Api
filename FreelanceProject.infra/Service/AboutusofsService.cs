using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class AboutusofsService : IAboutusofsService
    { 
        private readonly IAboutusofsRepository aboutusofsRepository;
        public AboutusofsService(IAboutusofsRepository aboutusofsRepository)
        {
            this.aboutusofsRepository = aboutusofsRepository;
        }

        public void delete(int id)
        {
            aboutusofsRepository.delete(id);
        }

        public List<Aboutusof> GetAll()
        {
            return aboutusofsRepository.GetAll();
        }

        public Aboutusof GetById(int id)
        {
            return aboutusofsRepository.GetById(id);
        }

        public void insert(Aboutusof aboutusof)
        {
            aboutusofsRepository.insert(aboutusof);
        }

        public void update(Aboutusof aboutusof)
        {
            aboutusofsRepository.update(aboutusof);
        }
    }
}
