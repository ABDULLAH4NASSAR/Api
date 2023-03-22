using FreelanceProject.Core.Data;
using FreelanceProject.Core.Service;
using FreelanceProject.infra.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FreelanceProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentmethodofService paymentmethodofService;
        public PaymentController(IPaymentmethodofService paymentmethodofService)
        {
            this.paymentmethodofService = paymentmethodofService;
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Paymentmethodof GetById(int id) { return paymentmethodofService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Paymentmethodof> GetAll() { return paymentmethodofService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { paymentmethodofService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Paymentmethodof paymentmethodof) { paymentmethodofService.update(paymentmethodof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Paymentmethodof paymentmethodof) { paymentmethodofService.insert(paymentmethodof); }
    }
}
