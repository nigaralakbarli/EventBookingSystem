using EventBookingSystem.Application.DTOs.Category.Request;
using EventBookingSystem.Application.DTOs.Category.Response;
using EventBookingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Application.Interfaces
{
    public interface ICategoryService
    {
        List<CategoryResponseDTO> GetCategories();
        CategoryResponseDTO GetCategoryById(int id);
        void CreateCategory(CategoryRequestDTO categoryRequestDTO);
        bool UpdateCategory(CategoryRequestDTO categoryRequestDTO);
        bool DeleteCategory(int id);
    }
}
