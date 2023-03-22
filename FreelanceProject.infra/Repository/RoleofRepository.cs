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
    public class RoleofRepository: IRoleofRepository
    {
        private readonly IDBContaxt dBContaxt;
        public RoleofRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;

        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("roleof_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Roleof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Roleof>("roleof_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Roleof GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Roleof>("roleof_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void insert(Roleof roleof)
        {
            var p = new DynamicParameters();
            p.Add("rolename", roleof.Namerole, dbType: DbType.String, direction: ParameterDirection.Input);
           
            var result = dBContaxt.Connection.Execute("roleof_package.insertrole", p, commandType: CommandType.StoredProcedure);
        }

        public void update(Roleof roleof)
        {
            var p = new DynamicParameters();
            p.Add("id1", roleof.Id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            p.Add("rolename", roleof.Namerole, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("roleof_package.updaterole", p, commandType: CommandType.StoredProcedure);
        }
    }
}
