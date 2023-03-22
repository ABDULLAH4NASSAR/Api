using Dapper;
using FreelanceProject.Core.Common;
using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.infra.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FreelanceProject.infra.Repository
{
    public class UseraccountofRepository : IUseraccountofRepository
    {
        private readonly IDBContaxt dBContaxt;
        public UseraccountofRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;

        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("USERACCOUNTOF_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Useraccountof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Useraccountof>("USERACCOUNTOF_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Useraccountof GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Useraccountof>("USERACCOUNTOF_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void insert(Useraccountof useraccountof)
        {
            var p = new DynamicParameters();
            p.Add("FIRSTNAME", useraccountof.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LASTNAME", useraccountof.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PHONENUMBER", useraccountof.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LOCATION", useraccountof.Location, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("EMAIL", useraccountof.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMAGE", useraccountof.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMAGETWO", useraccountof.Imagetwo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("BIRTHDATE", useraccountof.Birthdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("id_login", useraccountof.Id_Login, dbType: DbType.Int64, direction: ParameterDirection.Input);


            var result = dBContaxt.Connection.Execute("USERACCOUNTOF_package.insertUSERACCOUNTOF", p, commandType: CommandType.StoredProcedure);
        }
    

        public void update(Useraccountof useraccountof)
        {
        var p = new DynamicParameters();
            p.Add("id1", useraccountof.Id, dbType: DbType.Int64, direction: ParameterDirection.Input);

        p.Add("FIRSTNAME1", useraccountof.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
        p.Add("LASTNAME1", useraccountof.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
        p.Add("PHONENUMBER1", useraccountof.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
        p.Add("LOCATION1", useraccountof.Location, dbType: DbType.String, direction: ParameterDirection.Input);

        p.Add("EMAIL1", useraccountof.Email, dbType: DbType.String, direction: ParameterDirection.Input);
        p.Add("IMAGE1", useraccountof.Image, dbType: DbType.String, direction: ParameterDirection.Input);
        p.Add("IMAGETWO1", useraccountof.Imagetwo, dbType: DbType.String, direction: ParameterDirection.Input);
        p.Add("BIRTHDATE1", useraccountof.Birthdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
        p.Add("id_login1", useraccountof.Id_Login, dbType: DbType.Int64, direction: ParameterDirection.Input);


            var result = dBContaxt.Connection.Execute("USERACCOUNTOF_package.updateUSERACCOUNTOF", p, commandType: CommandType.StoredProcedure);
    }
}
}
