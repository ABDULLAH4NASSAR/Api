using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Service
{
    public interface IRoleofService
    {
        public Roleof GetById(int id);
        public List<Roleof> GetAll();
        public void delete(int id);
        public void update(Roleof roleof);

        public void insert(Roleof roleof);
    }
}
