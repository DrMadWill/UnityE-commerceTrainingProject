using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Unity_ETP.Business.Abstract;
using UnityETP.API.Models.ResultModels;
using UnityETP.API.Models.ResultModels.Questionnaire;
using UnityETP.Entity.Blogs;

namespace UnityETP.API.Controllers.Blogs
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoriesController : ControllerBase
    {
        private readonly IBaseService<Category, int> _blogCategoriesService;

        public BlogCategoriesController(IBaseService<Category, int> blogCategoriesService)
        {
            _blogCategoriesService = blogCategoriesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _blogCategoriesService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null) return StatusCode(StatusCodes.Status422UnprocessableEntity);
            var result = await _blogCategoriesService.GetAsync(b => b.Id == id);
            if (result == null) return StatusCode(StatusCodes.Status404NotFound);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SimpleQuestionnaire questionnaire)
        {
            var category = new Category
            {
                Name = questionnaire.Name,
            };
            if (category == null) return StatusCode(StatusCodes.Status422UnprocessableEntity);
            bool isFounded = await _blogCategoriesService.IsFoundDataBase(category.Id);
            if (isFounded) return StatusCode(StatusCodes.Status409Conflict);
            var result = await _blogCategoriesService.AddAsync(category);

            if (result?.IsSucceed == true) return Ok(result?.Result);
            else return BadRequest(new Error { Message = result?.ErrorMsg, Time = DateTime.Now, Status = result?.ErrorCode });
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] SimpleQuestionnaire questionnaire)
        {
            if (questionnaire == null) return StatusCode(StatusCodes.Status422UnprocessableEntity);

            var category = new Category
            {
                Id = questionnaire.Id,
                Name = questionnaire.Name,
            };

            var result = await _blogCategoriesService.UpdateAsync(category);
            if (result == null) return BadRequest(new Error { Message = result?.ErrorMsg, Time = DateTime.Now, Status = result?.ErrorCode });
            return Ok(result?.Result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return StatusCode(StatusCodes.Status422UnprocessableEntity);
            var result = await _blogCategoriesService.DeleteAsync(id ?? 0);
            if (result == null) return Ok(new Error { Message = "Entity Not Found" , Time =DateTime.Now, Status = StatusCodes.Status404NotFound });
            if (result.IsSucceed) return Ok(result?.Result);
            else return BadRequest(new Error { Message = result?.ErrorMsg, Time = DateTime.Now, Status = result?.ErrorCode });
        }


    }
}
