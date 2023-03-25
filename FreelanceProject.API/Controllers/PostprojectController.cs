using FreelanceProject.Core.Data;
using FreelanceProject.Core.Service;
using FreelanceProject.infra.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

namespace FreelanceProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostprojectController : ControllerBase
    {
        private readonly IPostprojectofService postprojectofService;
        private readonly IBanckofsService banckofsService;
        private readonly IFreelanceraccountofService freelanceraccountofService;
        private readonly IUseraccountofService useraccountofService;

        public PostprojectController(IUseraccountofService useraccountofService, IFreelanceraccountofService freelanceraccountofService, IPostprojectofService postprojectofService, IBanckofsService banckofsService)
        {
            this.postprojectofService = postprojectofService;
            this.banckofsService = banckofsService;
            this.freelanceraccountofService=freelanceraccountofService; 
            this.useraccountofService = useraccountofService;
        }
        [Route("userfile")]
        [HttpPost]
        public Postprojectof UploadIMage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("Images", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Postprojectof item = new Postprojectof();
            item.Attachmentfilefromuser = fileName;
            return item;
        }
        [Route("freelancerfile")]
        [HttpPost]
        public Postprojectof UploadIMage1()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("Images", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Postprojectof item = new Postprojectof();
            item.Attachmentfilefromfreelancer = fileName;
            return item;
        }

        [Route("progressfile")]
        [HttpPost]
        public Postprojectof UploadIMage2()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("Images", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Postprojectof item = new Postprojectof();
            item.Attachmentprogressproject = fileName;
            return item;
        }






        [HttpPost]
        [Route("payment")]
        public void p(Postprojectof postprojectof) 
        {

            var user = useraccountofService.GetById((int)postprojectof.Id_User);
            var userbank = banckofsService.GetById((int)user.id_bank);
            if (postprojectof.Status_Acceptorreject == 1 && userbank.Amount>=postprojectof.Payfixedprice ) 
            {

               
                userbank.Amount -= (decimal)postprojectof.Payfixedprice;
                banckofsService.update(userbank);

                var admin = banckofsService.GetById(1);
                admin.Amount = admin.Amount + ((decimal)postprojectof.Payfixedprice);
                banckofsService.update(admin);


                if (postprojectof.Status_Completeornot == 1) {
                    if (postprojectof.Startdate <= DateTime.Now && postprojectof.Enddate > DateTime.Now) 
                    {


                        var freelancer = freelanceraccountofService.GetById((int)postprojectof.ID_FREELANCER);

                        var bankforfreelancer = banckofsService.GetById((int)freelancer.id_bank);
                        bankforfreelancer.Amount += (decimal)postprojectof.Payfixedprice * 80 / 100;
                        banckofsService.update(bankforfreelancer);



                        admin.Amount = admin.Amount - ((decimal)postprojectof.Payfixedprice * 80 / 100);
                        banckofsService.update(admin);

                    }

                   

                }
              




            }
        
        
        
        }
















        [HttpGet]
        [Route("GetById/{id}")]
        public Postprojectof GetById(int id) { return postprojectofService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Postprojectof> GetAll() { return postprojectofService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { postprojectofService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Postprojectof postprojectof) { postprojectofService.update(postprojectof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Postprojectof postprojectof) { postprojectofService.insert(postprojectof); }
    }
}
