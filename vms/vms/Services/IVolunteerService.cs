﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vms.Models;

namespace vms.Services
{
    public interface IVolunteerService
    {
        Task<Volunteer[]> GetIncompleteVolunteersAsync();

        //IEnumerable<Volunteer> Volunteers { get; }
    }
}
