using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class ExperiencefreelanerofsService : IExperiencefreelanerofsService
    {
        private readonly IExperiencefreelanerofsRepository experiencefreelanerofsRepository;
        public ExperiencefreelanerofsService(IExperiencefreelanerofsRepository experiencefreelanerofsRepository)
        {
            this.experiencefreelanerofsRepository = experiencefreelanerofsRepository;
        }

        public void delete(int id)
        {
            experiencefreelanerofsRepository.delete(id);
        }

        public List<Experiencefreelanerof> GetAll()
        {
            return experiencefreelanerofsRepository.GetAll();
        }

        public Experiencefreelanerof GetById(int id)
        {
            return experiencefreelanerofsRepository.GetById(id);
        }

        public void insert(Experiencefreelanerof experiencefreelanerof)
        {
            experiencefreelanerofsRepository.insert(experiencefreelanerof);
        }

        public void update(Experiencefreelanerof experiencefreelanerof)
        {
            experiencefreelanerofsRepository.update(experiencefreelanerof);
        }
    }
}
