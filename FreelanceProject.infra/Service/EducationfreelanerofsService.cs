using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class EducationfreelanerofsService : IEducationfreelanerofsService
    {
        private readonly IEducationfreelanerofsRepository educationfreelanerofsRepository;
        public EducationfreelanerofsService(IEducationfreelanerofsRepository educationfreelanerofsRepository)
        {
            this.educationfreelanerofsRepository = educationfreelanerofsRepository;
        }

        public void delete(int id)
        {
            educationfreelanerofsRepository.delete(id);
        }

        public List<Educationfreelanerof> GetAll()
        {
            return educationfreelanerofsRepository.GetAll();
        }

        public Educationfreelanerof GetById(int id)
        {
            return educationfreelanerofsRepository.GetById(id);
        }

        public void insert(Educationfreelanerof educationfreelanerof)
        {
            educationfreelanerofsRepository.insert(educationfreelanerof);
        }

        public void update(Educationfreelanerof educationfreelanerof)
        {
            educationfreelanerofsRepository.update(educationfreelanerof);
        }
    }
}
