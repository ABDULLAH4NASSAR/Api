using Dapper;
using FreelanceProject.Core.Common;
using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FreelanceProject.infra.Repository
{
    public class CategoryofsRepository: ICategoryofsRepository
    {
        private readonly IDBContaxt dBContaxt;
        public CategoryofsRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;
        }

        public void delete(int id)
        {
            var p = new DynamicParameters();

            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("categoryof_package.Deletebyid", p,commandType: CommandType.StoredProcedure);
        }

        public List<Categoryof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Categoryof>("categoryof_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Categoryof GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Categoryof>("categoryof_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void insert(Categoryof categoryof)
        {
            var p = new DynamicParameters();
            p.Add("catname", categoryof.Catname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("image", categoryof.Image, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("categoryof_package.insertcategoryof", p, commandType: CommandType.StoredProcedure);
        }

        public void update(Categoryof categoryof)
        {
            var p = new DynamicParameters();
            p.Add("id1", categoryof.Id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            p.Add("catname1", categoryof.Catname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("image1", categoryof.Image, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("categoryof_package.updatecategoryof", p, commandType: CommandType.StoredProcedure);
        }
    }
}
