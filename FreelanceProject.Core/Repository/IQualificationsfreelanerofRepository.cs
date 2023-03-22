using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Repository
{
    public interface IQualificationsfreelanerofRepository
    {
        public Qualificationsfreelanerof GetById(int id);
        public List<Qualificationsfreelanerof> GetAll();
        public void delete(int id);
        public void update(Qualificationsfreelanerof qualificationsfreelanerof);

        public void insert(Qualificationsfreelanerof qualificationsfreelanerof);
    }
}
