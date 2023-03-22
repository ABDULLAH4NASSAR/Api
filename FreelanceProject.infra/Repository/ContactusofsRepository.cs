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
    public class ContactusofsRepository: IContactusofsRepository
    {
        private readonly IDBContaxt dBContaxt;
        public ContactusofsRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;
        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("CONTACTUSOF_package.Deletebyid",p, commandType: CommandType.StoredProcedure);
        }

        public List<Contactusof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Contactusof>("CONTACTUSOF_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Contactusof GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Contactusof>("CONTACTUSOF_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void insert(Contactusof contactusof)
        {
            var p = new DynamicParameters();
            p.Add("EMAIL", contactusof.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("NAME", contactusof.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("MESSAGE", contactusof.Message, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("CONTACTUSOF_package.insertCONTACTUSOF", p, commandType: CommandType.StoredProcedure);
        }

        public void update(Contactusof contactusof)
        {
            var p = new DynamicParameters();
            p.Add("id1", contactusof.Id, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("EMAIL1", contactusof.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("NAME1", contactusof.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("MESSAGE1", contactusof.Message, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("CONTACTUSOF_package.updateCONTACTUSOF", p, commandType: CommandType.StoredProcedure);
        }
    }
}
