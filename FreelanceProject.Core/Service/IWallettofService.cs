using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Service
{
    public interface IWallettofService
    {
        public Wallettof GetById(int id);
        public List<Wallettof> GetAll();
        public void delete(int id);
        public void update(Wallettof wallettof);

        public void insert(Wallettof wallettof);
    }
}
