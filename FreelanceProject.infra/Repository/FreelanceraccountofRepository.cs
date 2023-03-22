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
    public class FreelanceraccountofRepository: IFreelanceraccountofRepository
    {
        private readonly IDBContaxt dBContaxt;
        public FreelanceraccountofRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;
        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("FREELANCERACCOUNTOF_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Freelanceraccountof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Freelanceraccountof>("FREELANCERACCOUNTOF_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Freelanceraccountof GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Freelanceraccountof>("FREELANCERACCOUNTOF_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void insert(Freelanceraccountof freelanceraccountof)
        {
            var p = new DynamicParameters();
            p.Add("FIRSTNAME", freelanceraccountof.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LASTNAME", freelanceraccountof.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PHONENUMBER", freelanceraccountof.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LOCATION", freelanceraccountof.Location, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("EMAIL", freelanceraccountof.Email, dbType: DbType.String, direction: ParameterDirection.Input);


            p.Add("IMAGE", freelanceraccountof.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMAGETWO", freelanceraccountof.Imagetwo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("BIRTHDATE", freelanceraccountof.Birthdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("FACEBOOKLINK", freelanceraccountof.Facebooklink, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LINKEDINLINK", freelanceraccountof.Linkedinlink, dbType: DbType.String, direction: ParameterDirection.Input);


            p.Add("TWITTERLINK", freelanceraccountof.Twitterlink, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DESCRIBEYOURSELF", freelanceraccountof.Describeyourself, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LANGUGE", freelanceraccountof.Languge, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("RESUMEE", freelanceraccountof.Resumee, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ID_CAT", freelanceraccountof.Id_Cat, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("id_login", freelanceraccountof.Id_Login, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("FREELANCERACCOUNTOF_package.insertFREELANCERACCOUNTOF", p, commandType: CommandType.StoredProcedure);
        }

        public void update(Freelanceraccountof freelanceraccountof)
        {
            var p = new DynamicParameters();
            p.Add("id1", freelanceraccountof.Id, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("FIRSTNAME1", freelanceraccountof.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LASTNAME1", freelanceraccountof.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PHONENUMBER1", freelanceraccountof.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LOCATION1", freelanceraccountof.Location, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("EMAIL1", freelanceraccountof.Email, dbType: DbType.String, direction: ParameterDirection.Input);


            p.Add("IMAGE1", freelanceraccountof.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMAGETWO1", freelanceraccountof.Imagetwo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("BIRTHDATE1", freelanceraccountof.Birthdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("FACEBOOKLINK1", freelanceraccountof.Facebooklink, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LINKEDINLINK1", freelanceraccountof.Linkedinlink, dbType: DbType.String, direction: ParameterDirection.Input);


            p.Add("TWITTERLINK1", freelanceraccountof.Twitterlink, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DESCRIBEYOURSELF1", freelanceraccountof.Describeyourself, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LANGUGE1", freelanceraccountof.Languge, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("RESUMEE1", freelanceraccountof.Resumee, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ID_CAT1", freelanceraccountof.Id_Cat, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("id_login1", freelanceraccountof.Id_Login, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("FREELANCERACCOUNTOF_package.updateFREELANCERACCOUNTOF", p, commandType: CommandType.StoredProcedure);
        }
    }
}
