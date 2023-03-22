using FreelanceProject.Core.Data;
using FreelanceProject.Core.Service;
using FreelanceProject.infra.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace FreelanceProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryofsService categoryofsService;
        public CategoryController(ICategoryofsService categoryofsService)
        {
            this.categoryofsService = categoryofsService;
        }



        //[HttpPost]
        //[Route("upload")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        //public async Task<IActionResult> UploadFile(
        //IFormFile file,
        //CancellationToken cancellationToken)
        //{
        //    if (CheckIfExcelFile(file))
        //    {
        //        await WriteFile(file);
        //    }
        //    else
        //    {
        //        return BadRequest(new { message = "Invalid file extension" });
        //    }

        //    return Ok();
        //}

        ///// 

        ///// Method to check if file is excel file
        ///// 

        ///// 
        ///// 
        //private bool CheckIfExcelFile(IFormFile file)
        //{
        //    var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
        //    return (extension == ".xlsx" || extension == ".xls"); // Change the extension based on your need
        //}

        //private async Task<bool> WriteFile(IFormFile file)
        //{
        //    bool isSaveSuccess = false;
        //    string fileName;
        //    try
        //    {
        //        var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
        //        fileName = DateTime.Now.Ticks + extension; //Create a new Name for the file due to security reasons.

        //        var pathBuilt = Path.Combine(Directory.GetCurrentDirectory(), "Images");

        //        if (!Directory.Exists(pathBuilt))
        //        {
        //            Directory.CreateDirectory(pathBuilt);
        //        }

        //        var path = Path.Combine(Directory.GetCurrentDirectory(), "Images",
        //           fileName);

        //        using (var stream = new FileStream(path, FileMode.Create))
        //        {
        //            await file.CopyToAsync(stream);
        //        }

        //        isSaveSuccess = true;
        //    }
        //    catch (Exception e)
        //    {
        //        //log error
        //    }

        //    return isSaveSuccess;
        //}

        [Route("uploadImage")]
        [HttpPost]
        public Categoryof UploadIMage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("Images", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Categoryof item = new Categoryof();
            item.Image = fileName;
            return item;
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Categoryof GetById(int id) { return categoryofsService.GetById(id); }
        [HttpGet]
        [Route("GetAll")]
        public List<Categoryof> GetAll() { return categoryofsService.GetAll(); }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id) { categoryofsService.delete(id); }
        [HttpPut]
        [Route("update")]
        public void update(Categoryof categoryof) { categoryofsService.update(categoryof); }
        [HttpPost]
        [Route("insert")]
        public void insert(Categoryof categoryof) { categoryofsService.insert(categoryof); }
    }
}
