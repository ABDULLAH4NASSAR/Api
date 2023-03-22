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
    public class ReviewsofRepository: IReviewsofRepository
    {
        private readonly IDBContaxt dBContaxt;
        public ReviewsofRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;

        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("REVIEWSOF_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Reviewsof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Reviewsof>("REVIEWSOF_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Reviewsof GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Reviewsof>("REVIEWSOF_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void insert(Reviewsof reviewsof)
        {
            var p = new DynamicParameters();
            p.Add("COMMENTS", reviewsof.Comments, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ID_USER", reviewsof.Id_User, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("ID_FREELANCER", reviewsof.Id_Freelancer, dbType: DbType.Int64, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("REVIEWSOF_package.insertREVIEWSOF", p, commandType: CommandType.StoredProcedure);
        }

        public void update(Reviewsof reviewsof)
        {
            var p = new DynamicParameters();
            p.Add("id1", reviewsof.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("COMMENTS1", reviewsof.Comments, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ID_USER1", reviewsof.Id_User, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ID_FREELANCER1", reviewsof.Id_Freelancer, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("REVIEWSOF_package.updateREVIEWSOF", p, commandType: CommandType.StoredProcedure);
        }
    }
}
