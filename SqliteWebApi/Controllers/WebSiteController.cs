using SqliteWebApi.Data;
using SqliteWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace SqliteWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebSiteController : ControllerBase
    
    {

        private static readonly WebSiteDbContext db=new WebSiteDbContext();

       
        [HttpGet]
        public  List<WebSite> Get()
        {
            db.WebSites.Add(new WebSite{Url="Deneme2",Description="Merhaba"});
            db.SaveChanges();
            

            var result=db.WebSites.ToList();
            return result;

            
            
        }

    }
}