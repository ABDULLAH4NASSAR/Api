using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class QualificationsfreelanerofService : IQualificationsfreelanerofService
    {
        private readonly IQualificationsfreelanerofRepository qualificationsfreelanerofRepository;
        public QualificationsfreelanerofService(IQualificationsfreelanerofRepository qualificationsfreelanerofRepository)
        {
            this.qualificationsfreelanerofRepository = qualificationsfreelanerofRepository;
        }

        public void delete(int id)
        {
            qualificationsfreelanerofRepository.delete(id);
        }

        public List<Qualificationsfreelanerof> GetAll()
        {
            return qualificationsfreelanerofRepository.GetAll();
        }

        public Qualificationsfreelanerof GetById(int id)
        {
            return qualificationsfreelanerofRepository.GetById(id);
        }

        public void insert(Qualificationsfreelanerof qualificationsfreelanerof)
        {
            qualificationsfreelanerofRepository.insert(qualificationsfreelanerof);
        }

        public void update(Qualificationsfreelanerof qualificationsfreelanerof)
        {
            qualificationsfreelanerofRepository.update(qualificationsfreelanerof);
        }
    }
}
