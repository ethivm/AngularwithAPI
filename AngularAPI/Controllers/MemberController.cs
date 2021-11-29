using AngularAPI.Models;
using AngularAPI.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IRepository _repository;
        private IWebHostEnvironment _hostEnvironment;
        public MemberController(IRepository repository, IWebHostEnvironment environment)
        {
            _repository = repository;
            _hostEnvironment = environment;
        }
       
        [HttpPost]
        public ActionResult InsertMember([FromBody] member model)
        {
            string path = Path.Combine(this._hostEnvironment.WebRootPath, "Files/") + "";
            String json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            System.IO.File.WriteAllText(path + model.FirstName + "_" + model.LastName + ".json", json);
            return Ok();
        }

    }
}
