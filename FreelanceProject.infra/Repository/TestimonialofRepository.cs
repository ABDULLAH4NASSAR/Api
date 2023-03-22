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
    public class TestimonialofRepository: ITestimonialofRepository
    {
        private readonly IDBContaxt dBContaxt;
        public TestimonialofRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;

        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("TESTIMONIALOF_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Testimonialof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Testimonialof>("TESTIMONIALOF_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Testimonialof GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Testimonialof>("TESTIMONIALOF_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void insert(Testimonialof testimonialof)
        {
            var p = new DynamicParameters();
            p.Add("STATUS", testimonialof.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("COMMENTS", testimonialof.Comments, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ID_USER", testimonialof.Id_User, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("TESTIMONIALOF_package.insertTESTIMONIALOF", p, commandType: CommandType.StoredProcedure);
        }

        public void update(Testimonialof testimonialof)
        {
            var p = new DynamicParameters();
            p.Add("id1", testimonialof.Id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            p.Add("STATUS1", testimonialof.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("COMMENTS1", testimonialof.Comments, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ID_USER1", testimonialof.Id_User, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("TESTIMONIALOF_package.updateTESTIMONIALOF", p, commandType: CommandType.StoredProcedure);
        }
    }
}
