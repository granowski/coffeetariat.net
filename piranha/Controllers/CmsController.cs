using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Piranha;
using Blog.Models;

namespace Blog.Controllers
{
    public class CmsController : Controller
    {
        private readonly IApi _api;

        public CmsController(IApi api)
        {
            _api = api;
        }

        [Route("archive")]
        public async Task<IActionResult> Archive(Guid id, int? year = null, int? month = null, int? page = null,
            Guid? category = null, Guid? tag = null)
        {
            var model = await _api.Pages.GetByIdAsync<BlogArchive>(id);
            model.Archive = await _api.Archives.GetByIdAsync(id, page, category, tag, year, month);

            return View(model);
        }

        [Route("page")]
        public async Task<IActionResult> Page(Guid id)
        {
            var model = await _api.Pages.GetByIdAsync<StandardPage>(id);

            return View(model);
        }

        [Route("pagewide")]
        public async Task<IActionResult> PageWide(Guid id)
        {
            var model = await _api.Pages.GetByIdAsync<StandardPage>(id);

            return View(model);
        }

        [Route("post")]
        public async Task<IActionResult> Post(Guid id)
        {
            var model = await _api.Posts.GetByIdAsync<BlogPost>(id);

            return View(model);
        }
    }
}
