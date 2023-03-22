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
    public class PublicationsfreelanerofRepository: IPublicationsfreelanerofRepository
    {
        private readonly IDBContaxt dBContaxt;
        public PublicationsfreelanerofRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;
        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("PUBLICATIONSFREELANEROF_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Publicationsfreelanerof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Publicationsfreelanerof>("PUBLICATIONSFREELANEROF_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Publicationsfreelanerof GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Publicationsfreelanerof>("PUBLICATIONSFREELANEROF_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void insert(Publicationsfreelanerof publicationsfreelanerof)
        {
            var p = new DynamicParameters();
            p.Add("PUBLICATIONTITLE", publicationsfreelanerof.Publicationtitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PUBLISHER", publicationsfreelanerof.Publisher, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("SUMMARY", publicationsfreelanerof.Summary, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("STARTDATE", publicationsfreelanerof.Startdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ID_FREELANCER", publicationsfreelanerof.Id_Freelancer, dbType: DbType.Int64, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("PUBLICATIONSFREELANEROF_package.insertPUBLICATIONSFREELANEROF", p, commandType: CommandType.StoredProcedure);
        }

        public void update(Publicationsfreelanerof publicationsfreelanerof)
        {
            var p = new DynamicParameters();
            p.Add("id1", publicationsfreelanerof.Id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            p.Add("PUBLICATIONTITLE1", publicationsfreelanerof.Publicationtitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PUBLISHER1", publicationsfreelanerof.Publisher, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("SUMMARY1", publicationsfreelanerof.Summary, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("STARTDATE1", publicationsfreelanerof.Startdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ID_FREELANCER1", publicationsfreelanerof.Id_Freelancer, dbType: DbType.Int64, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("PUBLICATIONSFREELANEROF_package.updatePUBLICATIONSFREELANEROF", p, commandType: CommandType.StoredProcedure);
        }
    }
}
