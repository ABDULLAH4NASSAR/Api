using Dapper;
using FreelanceProject.Core.Common;
using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace FreelanceProject.infra.Repository
{
    public class AboutusofsRepository: IAboutusofsRepository
    {
        private readonly IDBContaxt dBContaxt;
        public AboutusofsRepository(IDBContaxt dBContaxt) 
        {
        this.dBContaxt = dBContaxt;
        
        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("ABOUTUSOF_package.Deletebyid",p, commandType: CommandType.StoredProcedure);
        }

        public List<Aboutusof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Aboutusof>("ABOUTUSOF_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Aboutusof GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Aboutusof>("ABOUTUSOF_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void insert(Aboutusof aboutusof)
        {
            var p = new DynamicParameters();
            p.Add("IMAGEURL", aboutusof.Imageurl, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PARGRAPH1", aboutusof.Pargraph1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PARGRAPH2", aboutusof.Pargraph2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PARGRAPH3", aboutusof.Pargraph3, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("ABOUTUSOF_package.insertABOUTUSOF", p, commandType: CommandType.StoredProcedure);
        }

        public void update(Aboutusof aboutusof)
        {
            var p = new DynamicParameters();
            p.Add("id1", aboutusof.Id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            p.Add("IMAGEURL1", aboutusof.Imageurl, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PARGRAPH11", aboutusof.Pargraph1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PARGRAPH21", aboutusof.Pargraph2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PARGRAPH31", aboutusof.Pargraph3, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("ABOUTUSOF_package.updateABOUTUSOF", p, commandType: CommandType.StoredProcedure);
        }
    }
}
