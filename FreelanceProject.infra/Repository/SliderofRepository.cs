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
    public class SliderofRepository: ISliderofRepository
    {
        private readonly IDBContaxt dBContaxt;
        public SliderofRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;

        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("sliderof_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Sliderof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Sliderof>("sliderof_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

     

        public void insert(Sliderof sliderof)
        {
            var p = new DynamicParameters();
            p.Add("BRANDNAME", sliderof.Brandname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMAGEURL", sliderof.Imageurl, dbType: DbType.String, direction: ParameterDirection.Input);
        
            var result = dBContaxt.Connection.Execute("sliderof_package.insertslider", p, commandType: CommandType.StoredProcedure);
        }

        public void update(Sliderof sliderof)
        {
            var p = new DynamicParameters();
            p.Add("id1", sliderof.Brandname, dbType: DbType.Int64, direction: ParameterDirection.Input);

            p.Add("BRANDNAME1", sliderof.Brandname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMAGEURL1", sliderof.Imageurl, dbType: DbType.String, direction: ParameterDirection.Input);
          
            var result = dBContaxt.Connection.Execute("sliderof_package.updateslider", p, commandType: CommandType.StoredProcedure);
        }
    }
}
