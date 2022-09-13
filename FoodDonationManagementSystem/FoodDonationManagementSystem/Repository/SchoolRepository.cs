using FoodDonationManagementSystem.DataAccess;
using FoodDonationManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagementSystem.Repository
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly SchoolDbContext _context;

        public SchoolRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddNewDonar(SchoolModule schoolModule)
        {
            try
            {
                var donar = new SchoolModule()
                {
                    Id = schoolModule.Id,
                    SchoolName = schoolModule.SchoolName,
       
                };
                _context.SchoolModule.Add(donar);
                await _context.SaveChangesAsync();
                return donar.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<SchoolModule>> GetAllDonars()
        {
            try
            {
                var records = await _context.SchoolModule.Select(x => new SchoolModule()
                {
                    Id = x.Id,
                    SchoolName = x.SchoolName,
                    
                }).ToListAsync();

                return records;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
