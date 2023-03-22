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
    public class WallettofRepository: IWallettofRepository
    {
        private readonly IDBContaxt dBContaxt;
        public WallettofRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;

        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("wallettof_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Wallettof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Wallettof>("wallettof_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Wallettof GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Wallettof>("wallettof_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void insert(Wallettof wallettof)
        {
            var p = new DynamicParameters();
            p.Add("AMOUNTINWALLET", wallettof.Amountinwallet, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("ID_PAYMENTMETHOD", wallettof.Id_Paymentmethod, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Wallettof>("wallettof_package.insertwallett", p, commandType: CommandType.StoredProcedure);

        }

        public void update(Wallettof wallettof)
        {
            var p = new DynamicParameters();
            p.Add("id1", wallettof.Id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            p.Add("AMOUNTINWALLET1", wallettof.Amountinwallet, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("ID_PAYMENTMETHOD1", wallettof.Id_Paymentmethod, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Wallettof>("wallettof_package.updatewallett", p, commandType: CommandType.StoredProcedure);
        }
    }
}
