using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Unity_ETP.Business.Abstract;
using UnityETP.Entity.Blogs;

namespace UnityETP.API.Controllers.Blogs
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IBaseService<Blog, int> _blogService;

        public BlogsController(IBaseService<Blog, int> blogService)
        {
            _blogService = blogService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result  = await _blogService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("Get/{id}")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null) return StatusCode(StatusCodes.Status422UnprocessableEntity);
            var result = await _blogService.GetAsync(b => b.Id == id);
            if (result == null) return StatusCode(StatusCodes.Status404NotFound);
            return Ok(result);
        }



    }
}
