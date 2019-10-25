using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections;
using SqliteWebApiDI.Data;
using SqliteWebApiDI.Models;

namespace SqliteWebApiDI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyBlogController: ControllerBase
    {

    
    private readonly MyBlogDbContext _context;

    public MyBlogController(MyBlogDbContext context)
    {
        _context= context;
    }
public List<Models.Blog> Get()
        {
            _context.Blogs.Add(new Blog{Content="Ne Waarrrr"});
            _context.SaveChanges();

            return _context.Blogs.ToList();
        }


    }
}