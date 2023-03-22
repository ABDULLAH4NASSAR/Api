using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Service
{
    public interface ISliderofService
    {
        public List<Sliderof> GetAll();
        public void delete(int id);
        public void update(Sliderof sliderof);

        public void insert(Sliderof sliderof);
    }
}
