using AutoMapper;
using EventBookingSystem.Application.DTOs.Category.Request;
using EventBookingSystem.Application.DTOs.Category.Response;
using EventBookingSystem.Application.DTOs.User.Request;
using EventBookingSystem.Application.Interfaces;
using EventBookingSystem.Domain.Entities;
using EventBookingSystem.Domain.Repositories.EntityRepositories;
using EventBookingSystem.Persistence.Repositories.EntityRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public void CreateCategory(CategoryRequestDTO categoryRequestDTO)
        {
            var mapped = _mapper.Map<Category>(categoryRequestDTO);
            _categoryRepository.Add(mapped);
        }

        public bool DeleteCategory(int id)
        {
            var category = _categoryRepository.GetById(id);
            if(category != null)
            {
                _categoryRepository.Remove(category);
                return true;
            }
            return false;
        }

        public List<CategoryResponseDTO> GetCategories()
        {
            var categories = _categoryRepository.GetAll();
            return _mapper.Map<List<CategoryResponseDTO>>(categories);    
        }

        public CategoryResponseDTO GetCategoryById(int id)
        {
            var category = _categoryRepository.GetById(id);
            return _mapper.Map<CategoryResponseDTO>(category);
        }

        public bool UpdateCategory(CategoryRequestDTO categoryRequestDTO)
        {
            var category = _categoryRepository.GetById(categoryRequestDTO.Id);
            if (category != null)
            {
                var mapped = _mapper.Map<Category>(categoryRequestDTO);
                _categoryRepository.Update(mapped);
                return true;
            }
            return false;
        }
    }
}
