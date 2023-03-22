using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Repository
{
    public interface ILoginofRepository
    {
        public Loginof Auth(Loginof loginof);
        public Loginof GetById(int id);
        public List<Loginof> GetAll();
        public void delete(int id);
        public void update(Loginof loginof);

        public int insert(Loginof loginof);
    }
}
