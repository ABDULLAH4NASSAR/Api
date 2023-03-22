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
   
    public class TestomonialfreelanceRepository : ITestomonialfreelnce
    {
        private readonly IDBContaxt dBContaxt;
        public TestomonialfreelanceRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;

        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("TESTIMONIALfreelancer_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Testomonialfreelancer> GetAll()
        {
            var result = dBContaxt.Connection.Query<Testomonialfreelancer>("TESTIMONIALfreelancer_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Testomonialfreelancer GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Testomonialfreelancer>("TESTIMONIALfreelancer_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void insert(Testomonialfreelancer testimonialof)
        {
            var p = new DynamicParameters();
            p.Add("STATUS", testimonialof.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("massage", testimonialof.Massage, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("id_freelancer", testimonialof.Id_Freelancer, dbType: DbType.Int64, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("TESTIMONIALfreelancer_package.insertTESTIMONIALOF", p, commandType: CommandType.StoredProcedure);
        }

        public void update(Testomonialfreelancer testimonialof)
        {
            var p = new DynamicParameters();
            p.Add("id1", testimonialof.Id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            p.Add("STATUS1", testimonialof.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("massage1", testimonialof.Massage, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("id_freelancer1", testimonialof.Id_Freelancer, dbType: DbType.Int64, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("TESTIMONIALfreelancer_package.updateTESTIMONIALOF", p, commandType: CommandType.StoredProcedure);
        }
    }
}
