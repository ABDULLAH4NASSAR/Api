using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Service
{
    public interface IHomepageofService
    {
        public Homepageof GetById(int id);
        public List<Homepageof> GetAll();
        public void delete(int id);
        public void update(Homepageof homepageof);

        public void insert(Homepageof homepageof);
    }
}
