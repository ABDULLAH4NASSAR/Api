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
    public class BanckofsRepository: IBanckofsRepository
    {
        private readonly IDBContaxt dBContaxt;
        public BanckofsRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;
        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("BANKOF_package.Deletebyid",p,commandType: CommandType.StoredProcedure);
        }

        public List<Banckof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Banckof>("BANKOF_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Banckof GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Banckof>("BANKOF_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public Banckof authbank(Banckof banckof)
        {
            var p = new DynamicParameters();
            p.Add("CARDNUMBER1", banckof.Cardnumber, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("cvv1", banckof.Cvv, dbType: DbType.Int64, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Query<Banckof>("BANKOF_package.authbank", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public int insert(Banckof banckof)
        {
            var p = new DynamicParameters();
            p.Add("CARDNUMBER1", banckof.Cardnumber, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("CARDHOLDERNAME1", banckof.Cardholdername, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("cvv1", banckof.Cvv, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("AMOUNT", banckof.Amount, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("EXPIRYDATE", banckof.Expirydate, dbType: DbType.DateTime, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Query<int>("BANKOF_package.insertBANKOF", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void update(Banckof banckof)
        {
            var p = new DynamicParameters();
            p.Add("id1", banckof.Id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("CARDNUMBER1", banckof.Cardnumber, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("CARDHOLDERNAME1", banckof.Cardholdername, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("cvv1", banckof.Cvv, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("AMOUNT1", banckof.Amount, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("EXPIRYDATE1", banckof.Expirydate, dbType: DbType.DateTime, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("BANKOF_package.updateBANKOF", p, commandType: CommandType.StoredProcedure);
        }
    }
}
