using EventBookingSystem.Application.DTOs.Category.Request;
using EventBookingSystem.Application.DTOs.RatingValue.Request;
using EventBookingSystem.Application.DTOs.RatingValue.Response;

namespace EventBookingSystem.Application.Interfaces;

public interface IRatingValueService
{
    List<RatingValueResponseDTO> GetRatingValues();
    RatingValueResponseDTO GetRatingValueById(int ratingId);
    void CreateRatingValue(RatingValueRequestDTO ratingValueRequestDTO);
    bool UpdateRatingValue(RatingValueRequestDTO ratingValueRequestDTO);
    bool DeleteRatingValue(int categoryId);
}
