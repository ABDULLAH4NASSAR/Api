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
    public class EducationfreelanerofsRepository: IEducationfreelanerofsRepository
    {
        private readonly IDBContaxt dBContaxt;
        public EducationfreelanerofsRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;
        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("EDUCATIONFREELANEROF_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Educationfreelanerof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Educationfreelanerof>("EDUCATIONFREELANEROF_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Educationfreelanerof GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Educationfreelanerof>("EDUCATIONFREELANEROF_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void insert(Educationfreelanerof educationfreelanerof)
        {
            var p = new DynamicParameters();
            p.Add("COUNTRY", educationfreelanerof.Country, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("UNIVERSITY_COLLEGE", educationfreelanerof.University_College, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DEGREE", educationfreelanerof.Degree, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("STARTDATE", educationfreelanerof.Startdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ENDDATE", educationfreelanerof.Enddate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ID_FREELANCER", educationfreelanerof.Id_Freelancer, dbType: DbType.Int64, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("EDUCATIONFREELANEROF_package.insertEDUCATIONFREELANEROF", p, commandType: CommandType.StoredProcedure);
        }

        public void update(Educationfreelanerof educationfreelanerof)
        {
            var p = new DynamicParameters();
            p.Add("id1", educationfreelanerof.Id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("COUNTRY1", educationfreelanerof.Country, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("UNIVERSITY_COLLEGE1", educationfreelanerof.University_College, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DEGREE1", educationfreelanerof.Degree, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("STARTDATE1", educationfreelanerof.Startdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ENDDATE1", educationfreelanerof.Enddate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ID_FREELANCER1", educationfreelanerof.Id_Freelancer, dbType: DbType.Int64, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("EDUCATIONFREELANEROF_package.updateEDUCATIONFREELANEROF", p, commandType: CommandType.StoredProcedure);
        }
    }
}
