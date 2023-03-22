using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class ContactusofsService : IContactusofsService
    {
        private readonly IContactusofsRepository contactusofsRepository;
        public ContactusofsService(IContactusofsRepository contactusofsRepository)
        {
            this.contactusofsRepository = contactusofsRepository;
        }

        public void delete(int id)
        {
            contactusofsRepository.delete(id);
        }

        public List<Contactusof> GetAll()
        {
            return contactusofsRepository.GetAll();
        }

        public Contactusof GetById(int id)
        {
            return (contactusofsRepository.GetById(id));
        }

        public void insert(Contactusof contactusof)
        {
            contactusofsRepository.insert(contactusof);
        }

        public void update(Contactusof contactusof)
        {
            contactusofsRepository.update(contactusof);
        }
    }
}
