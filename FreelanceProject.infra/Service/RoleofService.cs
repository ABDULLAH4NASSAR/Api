using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class RoleofService : IRoleofService
    {
        private readonly IRoleofRepository roleofRepository;
        public RoleofService(IRoleofRepository roleofRepository)
        {
            this.roleofRepository = roleofRepository;
        }

        public void delete(int id)
        {
            roleofRepository.delete(id);
        }

        public List<Roleof> GetAll()
        {
            return roleofRepository.GetAll();   
        }

        public Roleof GetById(int id)
        {
            return roleofRepository.GetById(id);
        }

        public void insert(Roleof roleof)
        {
            roleofRepository.insert(roleof);
        }

        public void update(Roleof roleof)
        {
            roleofRepository.update(roleof);
        }
    }
}
