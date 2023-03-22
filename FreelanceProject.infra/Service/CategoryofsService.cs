using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class CategoryofsService : ICategoryofsService
    {
        private readonly ICategoryofsRepository categoryofsRepository;
        public CategoryofsService(ICategoryofsRepository categoryofsRepository)
        {
            this.categoryofsRepository = categoryofsRepository;
        }

        public void delete(int id)
        {
            categoryofsRepository.delete(id);
        }

        public List<Categoryof> GetAll()
        {
            return categoryofsRepository.GetAll();
        }

        public Categoryof GetById(int id)
        {
            return (categoryofsRepository.GetById(id));
        }

        public void insert(Categoryof categoryof)
        {
            categoryofsRepository.insert(categoryof);
        }

        public void update(Categoryof categoryof)
        {
            categoryofsRepository.update(categoryof);
        }
    }
}
