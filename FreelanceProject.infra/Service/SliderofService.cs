using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class SliderofService : ISliderofService
    {
        private readonly ISliderofRepository sliderofRepository;
        public SliderofService(ISliderofRepository sliderofRepository)
        {
            this.sliderofRepository = sliderofRepository;
        }

        public void delete(int id)
        {
            sliderofRepository.delete(id);
        }

        public List<Sliderof> GetAll()
        {
            return sliderofRepository.GetAll();
        }

        public void insert(Sliderof sliderof)
        {
            sliderofRepository.insert(sliderof);    
        }

        public void update(Sliderof sliderof)
        {
            sliderofRepository.update(sliderof);
        }
    }
}
