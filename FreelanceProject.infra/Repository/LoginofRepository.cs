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
    public class LoginofRepository: ILoginofRepository
    {
        private readonly IDBContaxt dBContaxt;
        public LoginofRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;
        }

        public Loginof Auth(Loginof loginof)
        {
            var p = new DynamicParameters();

            p.Add("username1",loginof.Username,dbType:DbType.String,direction:ParameterDirection.Input);
            p.Add("password1",loginof.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Loginof>("loginof_package.auth", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();

        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("loginof_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Loginof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Loginof>("loginof_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Loginof GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Loginof>("loginof_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public int insert(Loginof loginof)
        {
            var p = new DynamicParameters();
            p.Add("username1", loginof.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("password1", loginof.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("id_role1", loginof.Id_Role, dbType: DbType.Int32, direction: ParameterDirection.Input);
        

            var result = dBContaxt.Connection.Query<int>("loginof_package.insertlogin", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void update(Loginof loginof)
        {
            var p = new DynamicParameters();
            p.Add("id1", loginof.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("username1", loginof.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("password1", loginof.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("id_role1", loginof.Id_Role, dbType: DbType.Int32, direction: ParameterDirection.Input);
           

            var result = dBContaxt.Connection.Execute("loginof_package.updatelogin", p, commandType: CommandType.StoredProcedure);
        }
    }
}
