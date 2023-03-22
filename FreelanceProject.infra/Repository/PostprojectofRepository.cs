using Dapper;
using FreelanceProject.Core.Common;
using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.infra.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FreelanceProject.infra.Repository
{
    public class PostprojectofRepository : IPostprojectofRepository
    {
        private readonly IDBContaxt dBContaxt;
        public PostprojectofRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;
        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("POSTPROJECTOF_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Postprojectof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Postprojectof>("POSTPROJECTOF_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Postprojectof GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Postprojectof>("POSTPROJECTOF_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void insert(Postprojectof postprojectof)
        {
            var p = new DynamicParameters();
            p.Add("NAME", postprojectof.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DESCRIPTION", postprojectof.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("SKILLSREQUIRED", postprojectof.Skillsrequired, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("CURRENCY", postprojectof.Currency, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("AMOUNTTOPAYBYHOURS", postprojectof.Amounttopaybyhours, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("PAYFIXEDPRICE", postprojectof.Payfixedprice, dbType: DbType.Int32, direction: ParameterDirection.Input);



            p.Add("TOTALFEES", postprojectof.Totalfees, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("PROFITSAMOUNT", postprojectof.Profitsamount, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("STARTDATE", postprojectof.Startdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ENDDATE", postprojectof.Enddate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("STATUS_COMPLETEORNOT", postprojectof.Status_Completeornot, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("STATUS_ACCEPTORREJECT", postprojectof.Status_Acceptorreject, dbType: DbType.Int32, direction: ParameterDirection.Input);




            p.Add("STATUS_ACCEPTSOLUTION", postprojectof.Status_Acceptsolution, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("ATTACHMENTFILEFROMUSER", postprojectof.Attachmentfilefromuser, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ATTACHMENTFILEFROMFREELANCER", postprojectof.Attachmentfilefromfreelancer, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ATTACHMENTPROGRESSPROJECT", postprojectof.Attachmentprogressproject, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ID_USER", postprojectof.Id_User, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("id_freelancer", postprojectof.ID_FREELANCER, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("POSTPROJECTOF_package.insertPOSTPROJECTOF", p, commandType: CommandType.StoredProcedure);
        }


        public void update(Postprojectof postprojectof)
        {
            var p = new DynamicParameters();
            p.Add("id1", postprojectof.Id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            p.Add("NAME1", postprojectof.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DESCRIPTION1", postprojectof.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("SKILLSREQUIRED1", postprojectof.Skillsrequired, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("CURRENCY1", postprojectof.Currency, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("AMOUNTTOPAYBYHOURS1", postprojectof.Amounttopaybyhours, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("PAYFIXEDPRICE1", postprojectof.Payfixedprice, dbType: DbType.Int32, direction: ParameterDirection.Input);



            p.Add("TOTALFEES1", postprojectof.Totalfees, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("PROFITSAMOUNT1", postprojectof.Profitsamount, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("STARTDATE1", postprojectof.Startdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ENDDATE1", postprojectof.Enddate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("STATUS_COMPLETEORNOT1", postprojectof.Status_Completeornot, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("STATUS_ACCEPTORREJECT1", postprojectof.Status_Acceptorreject, dbType: DbType.Int32, direction: ParameterDirection.Input);




            p.Add("STATUS_ACCEPTSOLUTION1", postprojectof.Status_Acceptsolution, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("ATTACHMENTFILEFROMUSER1", postprojectof.Attachmentfilefromuser, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ATTACHMENTFILEFROMFREELANCER1", postprojectof.Attachmentfilefromfreelancer, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ATTACHMENTPROGRESSPROJECT1", postprojectof.Attachmentprogressproject, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ID_USER1", postprojectof.Id_User, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("id_freelancer1", postprojectof.ID_FREELANCER, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("POSTPROJECTOF_package.updatePOSTPROJECTOF", p, commandType: CommandType.StoredProcedure);

        }
    }
}