using Exo_ASPMVC_01.Models;
using Exo_ASPMVC_01.Services;
using Microsoft.AspNetCore.Mvc;

namespace Exo_ASPMVC_01.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogService _blogService;
        public BlogController()
        {
            _blogService = new BlogService();
        }

        public IActionResult Index(int page = 1)
        {
            IEnumerable<Blog> blogArticles = _blogService.GetByPage(page, 5);
            ViewData["Page"] = page;
            return View(blogArticles);
        }
    }
}
