using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Service
{
    public interface IQualificationsfreelanerofService
    {
        public Qualificationsfreelanerof GetById(int id);
        public List<Qualificationsfreelanerof> GetAll();
        public void delete(int id);
        public void update(Qualificationsfreelanerof qualificationsfreelanerof);

        public void insert(Qualificationsfreelanerof qualificationsfreelanerof);
    }
}
