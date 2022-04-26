using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ExploreCalifornia.Controllers
{
    [Route("blog")]  // be careful, this removes it as being a candidate for more generic routes defined in the startup class though usually desireable
    public class BlogController : Controller
    {
        //GET: /<controller>/
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            var post = new Post
            {
                Title = "My blog post",
                Posted = DateTime.Now,
                Author = "Jeremy MacDougall",
                Body = "This is a great blog post, don't you think?",
            };
            /*
            ViewBag.Title = "My blog post";
            ViewBag.Posted = DateTime.Now;
            ViewBag.Author = "Jeremy MacDougall";
            ViewBag.Body = "This is a great blog post, don't you think?";
            */
            return View(post);
        }

        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("create")]
        public IActionResult Create(Post post)
        {
          if (ModelState.IsValid)
                return View(); // keep processing the request

            post.Author = User.Identity.Name;
            post.Posted = DateTime.Now;
            return View();

        }

       
    }
}