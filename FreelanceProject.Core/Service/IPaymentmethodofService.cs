using FreelanceProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.Core.Service
{
    public interface IPaymentmethodofService
    {
        public Paymentmethodof GetById(int id);
        public List<Paymentmethodof> GetAll();
        public void delete(int id);
        public void update(Paymentmethodof paymentmethodof);

        public void insert(Paymentmethodof paymentmethodof);
    }
}
