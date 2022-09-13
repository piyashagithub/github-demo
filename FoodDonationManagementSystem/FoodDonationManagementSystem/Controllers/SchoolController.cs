using FoodDonationManagementSystem.DataAccess;
using FoodDonationManagementSystem.Models;
using FoodDonationManagementSystem.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly SchoolRepository _schoolRepository;
        private readonly SchoolDbContext _schoolDbContext;

        public SchoolController(SchoolRepository schoolRepository, SchoolDbContext schoolDbContext)
        {
            _schoolRepository = schoolRepository;
            _schoolDbContext = schoolDbContext;
        }

        [HttpGet]
        [Route("Getting Donars")]
        public async Task<IActionResult> GetAllDonar()
        {
            try
            {
                var donars = await _schoolRepository.GetAllDonars();
                return Ok(donars);
            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpPost]
        [Route("Donar details")]
        public async Task<IActionResult> AddDonar([FromBody] SchoolModule schoolModule)
        {
            try
            {
                var donar = await _schoolRepository.AddNewDonar(schoolModule);
                return Ok(donar);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
