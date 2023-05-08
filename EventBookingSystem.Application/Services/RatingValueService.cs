using AutoMapper;
using EventBookingSystem.Application.DTOs.Category.Request;
using EventBookingSystem.Application.DTOs.RatingValue.Request;
using EventBookingSystem.Application.DTOs.RatingValue.Response;
using EventBookingSystem.Application.Interfaces;
using EventBookingSystem.Domain.Entities;
using EventBookingSystem.Domain.Repositories.EntityRepositories;
using EventBookingSystem.Persistence.Repositories.EntityRepositories;

namespace EventBookingSystem.Application.Services;

public class RatingValueService : IRatingValueService
{
    private readonly IRatingValueRepository _ratingValueRepository;
    private readonly IMapper _mapper;

    public RatingValueService(
        IRatingValueRepository ratingValueRepository,
        IMapper mapper)
    {
        _ratingValueRepository = ratingValueRepository;
        _mapper = mapper;
    }

    public List<RatingValueResponseDTO> GetRatingValues()
    {
        return _mapper.Map<List<RatingValueResponseDTO>>(_ratingValueRepository.GetAll());
    }
    public RatingValueResponseDTO GetRatingValueById(int ratingId)
    {
        var ratingValue = _ratingValueRepository.GetById(ratingId);
        return _mapper.Map<RatingValueResponseDTO>(ratingValue);
    }
    public void CreateRatingValue(RatingValueRequestDTO ratingValueRequestDTO)
    {
        var ratingValue = _mapper.Map<RatingValue>(ratingValueRequestDTO);
        _ratingValueRepository.Add(ratingValue);
    }
    public bool DeleteRatingValue(int ratingId)
    {
        var ratingValue = _ratingValueRepository.GetById(ratingId);
        if (ratingValue != null)
        {
            _ratingValueRepository.Remove(ratingValue);
            return true;
        }
        return false;
    }
    public bool UpdateRatingValue(RatingValueRequestDTO ratingValueRequestDTO)
    {
        var ratingValue = _ratingValueRepository.GetById(ratingValueRequestDTO.Id);
        if (ratingValue != null)
        {
            var mapped = _mapper.Map<RatingValue>(ratingValueRequestDTO);
            _ratingValueRepository.Update(mapped);
            return true;
        }
        return false;
    }
    
}
