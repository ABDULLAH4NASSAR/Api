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
    public class HomepageofRepository: IHomepageofRepository
    {
        private readonly IDBContaxt dBContaxt;
        public HomepageofRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;
        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("HOMEPAGEOF_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Homepageof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Homepageof>("HOMEPAGEOF_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Homepageof GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Homepageof>("HOMEPAGEOF_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void insert(Homepageof homepageof)
        {
            var p = new DynamicParameters();
            p.Add("LOGOURL", homepageof.Logourl, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMAGEURL", homepageof.Imageurl, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("NAMEPLATFORM", homepageof.Nameplatform, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("EMAIL", homepageof.Email, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ADDRESS", homepageof.Address, dbType: DbType.Int32, direction: ParameterDirection.Input);


            p.Add("TEXTONE", homepageof.Textone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TEXTTWO", homepageof.Texttwo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TEXTTHREE", homepageof.Textthree, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("LOCATION", homepageof.Location, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("PHONENUMBER", homepageof.Phonenumber, dbType: DbType.Int32, direction: ParameterDirection.Input);


            p.Add("FACEBOOKLINK", homepageof.Facebooklink, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("INSTAGRAMLINK", homepageof.Instagramlink, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TWITTER", homepageof.Twitter, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("WHATSAPP", homepageof.Whatsapp, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("PHONENUMBER", homepageof.Phonenumber, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("HOMEPAGEOF_package.insertHOMEPAGEOF", p, commandType: CommandType.StoredProcedure);
        }

        public void update(Homepageof homepageof)
        {
            var p = new DynamicParameters();
            p.Add("id1", homepageof.Id, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("LOGOURL1", homepageof.Logourl, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMAGEURL1", homepageof.Imageurl, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("NAMEPLATFORM1", homepageof.Nameplatform, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("EMAIL1", homepageof.Email, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ADDRESS1", homepageof.Address, dbType: DbType.Int32, direction: ParameterDirection.Input);


            p.Add("TEXTONE1", homepageof.Textone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TEXTTWO1", homepageof.Texttwo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TEXTTHREE1", homepageof.Textthree, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("LOCATION1", homepageof.Location, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("PHONENUMBER1", homepageof.Phonenumber, dbType: DbType.Int32, direction: ParameterDirection.Input);


            p.Add("FACEBOOKLINK1", homepageof.Facebooklink, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("INSTAGRAMLINK1", homepageof.Instagramlink, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TWITTER1", homepageof.Twitter, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("WHATSAPP1", homepageof.Whatsapp, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("PHONENUMBER1", homepageof.Phonenumber, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("HOMEPAGEOF_package.updateHOMEPAGEOF", p, commandType: CommandType.StoredProcedure);
        }
    }
}
