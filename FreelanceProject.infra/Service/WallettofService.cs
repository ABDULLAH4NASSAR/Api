using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class WallettofService : IWallettofService
    {
        private readonly IWallettofRepository wallettofRepository;
        public WallettofService(IWallettofRepository wallettofRepository)
        {
            this.wallettofRepository = wallettofRepository;
        }

        public void delete(int id)
        {
            wallettofRepository.delete(id);
        }

        public List<Wallettof> GetAll()
        {
            return wallettofRepository.GetAll();
        }

        public Wallettof GetById(int id)
        {
            return wallettofRepository.GetById(id);
        }

        public void insert(Wallettof wallettof)
        {
            wallettofRepository.insert(wallettof);
        }

        public void update(Wallettof wallettof)
        {
            wallettofRepository.update(wallettof);
        }
    }
}
