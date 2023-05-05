using EventBookingSystem.Application.DTOs.Category.Request;
using EventBookingSystem.Application.DTOs.User.Request;
using EventBookingSystem.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingSystem.WebApi.Controllers
{
    [Route("CategoryController")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        //[Authorize(Roles = "Admin")]
        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetCategories()
        {
            var categories = _categoryService.GetCategories();
            return Ok(categories);
        }

        //[Authorize(Roles = "Admin")]
        [Route("GetById")]
        [HttpGet]
        public IActionResult GetCategoryById(int id)
        {

            var category = _categoryService.GetCategoryById(id);
            return Ok(category);
        }

        //[Authorize(Roles = "Admin")]
        [Route("Create")]
        [HttpPost]
        public IActionResult CreateCategory(CategoryRequestDTO categoryRequestDTO)
        {
            _categoryService.CreateCategory(categoryRequestDTO);
            return Ok();
        }

        //[Authorize(Roles = "Admin")]
        [Route("Update")]
        [HttpPost]
        public IActionResult UpdateCategory(CategoryRequestDTO categoryRequestDTO)
        {

            if (!_categoryService.UpdateCategory(categoryRequestDTO))
            {
                return BadRequest($"Category with ID {categoryRequestDTO.Id} not found.");
            }
            return Ok();
        }

        //[Authorize(Roles = "Admin")]
        [Route("Delete")]
        [HttpDelete]
        public IActionResult DeleteCategory(int categoryId)
        {
            if (!_categoryService.DeleteCategory(categoryId))
            {
                return BadRequest($"Category with ID {categoryId} not found.");
            }
            return Ok();
        }
    }
}
