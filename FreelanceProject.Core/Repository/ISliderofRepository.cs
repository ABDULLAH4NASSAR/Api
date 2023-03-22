using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Repository
{
    public interface ISliderofRepository
    {
        public List<Sliderof> GetAll();
        public void delete(int id);
        public void update(Sliderof sliderof);

        public void insert(Sliderof sliderof);
    }
}
