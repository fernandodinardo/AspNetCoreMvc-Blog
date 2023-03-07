using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvc_Blog.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
