using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class PostprojectofService : IPostprojectofService
    {
        private readonly IPostprojectofRepository postprojectofRepository;
        public PostprojectofService(IPostprojectofRepository postprojectofRepository)
        {
            this.postprojectofRepository = postprojectofRepository;
        }

        public void delete(int id)
        {
            postprojectofRepository.delete(id);
        }

        public List<Postprojectof> GetAll()
        {
            return postprojectofRepository.GetAll();
        }

        public Postprojectof GetById(int id)
        {
            return postprojectofRepository.GetById(id);
        }

        public void insert(Postprojectof postprojectof)
        {
            postprojectofRepository.insert(postprojectof);
        }

        public void update(Postprojectof postprojectof)
        {
            postprojectofRepository.update(postprojectof);
        }
    }
}
