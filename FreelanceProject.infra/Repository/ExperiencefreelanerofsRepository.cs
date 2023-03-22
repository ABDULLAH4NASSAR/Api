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
    public class ExperiencefreelanerofsRepository: IExperiencefreelanerofsRepository
    {
        private readonly IDBContaxt dBContaxt;
        public ExperiencefreelanerofsRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;
        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("EXPERIENCEFREELANEROF_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Experiencefreelanerof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Experiencefreelanerof>("EXPERIENCEFREELANEROF_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Experiencefreelanerof GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Experiencefreelanerof>("EXPERIENCEFREELANEROF_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void insert(Experiencefreelanerof experiencefreelanerof)
        {
            var p = new DynamicParameters();
            p.Add("TITLE", experiencefreelanerof.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("COMPANY", experiencefreelanerof.Company, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("SUMMARY", experiencefreelanerof.Summary, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("STARTDATE", experiencefreelanerof.Startdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ENDDATE", experiencefreelanerof.Enddate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ID_FREELANCER", experiencefreelanerof.Id_Freelancer, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("status", experiencefreelanerof.status, dbType: DbType.String, direction: ParameterDirection.Input);


            var result = dBContaxt.Connection.Execute("EXPERIENCEFREELANEROF_package.insertEXPERIENCEFREELANEROF", p, commandType: CommandType.StoredProcedure);
        }

        public void update(Experiencefreelanerof experiencefreelanerof)
        {
            var p = new DynamicParameters();
            p.Add("id1", experiencefreelanerof.Id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("TITLE1", experiencefreelanerof.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("COMPANY1", experiencefreelanerof.Company, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("SUMMARY1", experiencefreelanerof.Summary, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("STARTDATE1", experiencefreelanerof.Startdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ENDDATE1", experiencefreelanerof.Enddate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ID_FREELANCER1", experiencefreelanerof.Id_Freelancer, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("status1", experiencefreelanerof.status, dbType: DbType.String, direction: ParameterDirection.Input);


            var result = dBContaxt.Connection.Execute("EXPERIENCEFREELANEROF_package.updateEXPERIENCEFREELANEROF", p, commandType: CommandType.StoredProcedure);
        }
    }
}
