using AnimalShopWebApi_UG.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnimalShopWebApi_UG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {
        //public readonly ApplicationDbContext _dbCon;

        //public AnimalController(ApplicationDbContext dbCon)
        //{
        //    //this._dbCon = dbCon;
        //}

        [HttpGet]
        public string Get()
        {
            //Dupskp();
            //var resoult = _dbCon.Animals.ToList();
            //var aa = resoult.FirstOrDefault();
            //var aaa = aa.Name;
            //return aaa;
            return "dupa";
        }

        //void Dupskp()
        //{
        //    var a = new Animal() { Name = "Dupa" };
        //    _dbCon.Animals.Add(a);
        //    _dbCon.SaveChanges();
        //}

    }
}
