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
    public class PaymentmethodofRepository: IPaymentmethodofRepository
    {
        private readonly IDBContaxt dBContaxt;
        public PaymentmethodofRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;
        }

        public void delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("PAYMENTMETHODOF_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Paymentmethodof> GetAll()
        {
            var result = dBContaxt.Connection.Query<Paymentmethodof>("PAYMENTMETHODOF_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Paymentmethodof GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Paymentmethodof>("PAYMENTMETHODOF_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void insert(Paymentmethodof paymentmethodof)
        {
            var p = new DynamicParameters();
            p.Add("CARD", paymentmethodof.Card, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("EXPIRYDATE", paymentmethodof.Expirydate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("CARDHOLDERNAME", paymentmethodof.Cardholdername, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("CVC_CVV", paymentmethodof.Cvc_Cvv, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ID_USER", paymentmethodof.Id_User, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ID_FREELANCER", paymentmethodof.Id_Freelancer, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("PAYMENTMETHODOF_package.insertPAYMENTMETHODOF", p, commandType: CommandType.StoredProcedure);
        }

        public void update(Paymentmethodof paymentmethodof)
        {
            var p = new DynamicParameters();
            p.Add("id1", paymentmethodof.Id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            p.Add("CARD1", paymentmethodof.Card, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("EXPIRYDATE1", paymentmethodof.Expirydate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("CARDHOLDERNAME1", paymentmethodof.Cardholdername, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("CVC_CVV1", paymentmethodof.Cvc_Cvv, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ID_USER1", paymentmethodof.Id_User, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ID_FREELANCER1", paymentmethodof.Id_Freelancer, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("PAYMENTMETHODOF_package.updateHPAYMENTMETHODOF", p, commandType: CommandType.StoredProcedure);
        }
    }
}
