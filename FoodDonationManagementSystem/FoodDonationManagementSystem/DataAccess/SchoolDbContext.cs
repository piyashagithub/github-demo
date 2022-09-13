using FoodDonationManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagementSystem.DataAccess
{
    [TestClass]
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
            {
            }


    //to add a new class in this context clss we use dbset
    public DbSet<SchoolModule> SchoolModule { get; set; }

   
}
}
