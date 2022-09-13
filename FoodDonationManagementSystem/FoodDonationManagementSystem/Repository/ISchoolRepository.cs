using FoodDonationManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagementSystem.Repository
{
    public interface ISchoolRepository
    {
        Task<int> AddNewDonar(SchoolModule schoolModule);
    }
}
