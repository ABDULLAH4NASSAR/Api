using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class BanckofsService : IBanckofsService
    {
        private readonly IBanckofsRepository banckofsRepository;
        public BanckofsService(IBanckofsRepository banckofsRepository)
        {
            this.banckofsRepository = banckofsRepository;
        }

        public Banckof authbank(Banckof banckof)
        {
            return banckofsRepository.authbank(banckof);
        }

        public void delete(int id)
        {
           banckofsRepository.delete(id);
                
        }

        public List<Banckof> GetAll()
        {
            return banckofsRepository.GetAll();
        }

        public Banckof GetById(int id)
        {
            return banckofsRepository.GetById(id);
        }

        public int insert(Banckof banckof)
        {
            return banckofsRepository.insert(banckof);
        }

        public void update(Banckof banckof)
        {
            banckofsRepository.update(banckof);
        }
    }
}
