using EventBookingSystem.Application.DTOs.Venue.Request;
using EventBookingSystem.Application.DTOs.Venue.Response;
using EventBookingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Application.Interfaces;

public interface IVenueService
{
    VenueResponseDTO GetVenueById(int id);
    List<VenueResponseDTO> GetVenues();
    void CreateVenue(VenueRequestDTO venueDto);
    bool DeleteVenue(int id);
    bool UpdateVenue(VenueRequestDTO venueRequestDTO);
}
