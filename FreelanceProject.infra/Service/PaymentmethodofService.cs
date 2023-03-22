using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class PaymentmethodofService : IPaymentmethodofService
    {
        private readonly IPaymentmethodofRepository paymentmethodofRepository;
        public PaymentmethodofService(IPaymentmethodofRepository paymentmethodofRepository)
        {
            this.paymentmethodofRepository = paymentmethodofRepository;
        }

        public void delete(int id)
        {
            paymentmethodofRepository.delete(id);
        }

        public List<Paymentmethodof> GetAll()
        {
            return paymentmethodofRepository.GetAll();
        }

        public Paymentmethodof GetById(int id)
        {
            return paymentmethodofRepository.GetById(id);
        }

        public void insert(Paymentmethodof paymentmethodof)
        {
            paymentmethodofRepository.insert(paymentmethodof);
        }

        public void update(Paymentmethodof paymentmethodof)
        {
            paymentmethodofRepository.update(paymentmethodof);
        }
    }
}
