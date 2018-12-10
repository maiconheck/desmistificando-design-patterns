using System;
using DesignPatternsDemo.Factories.Fake.Application;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternsDemo.Factories.Controllers
{
    [Route("api/v1/[Controller]")]
    public class CategoryController : Controller
    {
        private readonly CategoryApplicationService _categoryAppService;

        public CategoryController(CategoryApplicationService categoryAppService)
        {
            _categoryAppService = categoryAppService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateCategoryCommand command)
        {
            var result = _categoryAppService.Handle(command);
            return Ok(result);
        }

        [HttpPut]
        [Route("{id}/deactivate")]
        public IActionResult Put(Guid id, [FromBody] DeactivateCategoryCommand command)
        {
            command.Id = id;
            var result = _categoryAppService.Handle(command);
            return Ok(result);
        }
    }
}