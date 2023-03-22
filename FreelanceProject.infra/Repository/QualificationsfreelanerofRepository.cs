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
    public class QualificationsfreelanerofRepository : IQualificationsfreelanerofRepository
    {
        private readonly IDBContaxt dBContaxt;
        public QualificationsfreelanerofRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;

        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("QUALIFICATIONSFREELANEROF_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Qualificationsfreelanerof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Qualificationsfreelanerof>("QUALIFICATIONSFREELANEROF_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Qualificationsfreelanerof GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Qualificationsfreelanerof>("QUALIFICATIONSFREELANEROF_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void insert(Qualificationsfreelanerof qualificationsfreelanerof)
        {
            var p = new DynamicParameters();
            p.Add("PROFESSIONALCERTIFICATE_AWARD", qualificationsfreelanerof.Professionalcertificate_Award, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("CONFERRINGORGANIZATION", qualificationsfreelanerof.Conferringorganization, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("SUMMARY", qualificationsfreelanerof.Summary, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("STARTDATE", qualificationsfreelanerof.Startdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ID_FREELANCER", qualificationsfreelanerof.Id_Freelancer, dbType: DbType.Int64, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("QUALIFICATIONSFREELANEROF_package.insertQUALIFICATIONSFREELANEROF", p, commandType: CommandType.StoredProcedure);
        }


        public void update(Qualificationsfreelanerof qualificationsfreelanerof)
        {
            var p = new DynamicParameters();
            p.Add("id1", qualificationsfreelanerof.Id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            p.Add("PROFESSIONALCERTIFICATE_AWARD1", qualificationsfreelanerof.Professionalcertificate_Award, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("CONFERRINGORGANIZATION1", qualificationsfreelanerof.Conferringorganization, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("SUMMARY1", qualificationsfreelanerof.Summary, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("STARTDATE1", qualificationsfreelanerof.Startdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ID_FREELANCER1", qualificationsfreelanerof.Id_Freelancer, dbType: DbType.Int64, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("QUALIFICATIONSFREELANEROF_package.updateQUALIFICATIONSFREELANEROF", p, commandType: CommandType.StoredProcedure);
        }
    }
}
