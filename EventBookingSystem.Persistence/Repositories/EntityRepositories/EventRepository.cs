﻿using EventBookingSystem.Domain.Entities;
using EventBookingSystem.Domain.Repositories.EntityRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Persistence.Repositories.EntityRepositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
    }
}
