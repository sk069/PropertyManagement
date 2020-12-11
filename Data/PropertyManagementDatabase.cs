﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PropertyManagement.Models;

namespace PropertyManagement.Data
{
    public class PropertyManagementDatabase : DbContext
    {
        public PropertyManagementDatabase (DbContextOptions<PropertyManagementDatabase> options)
            : base(options)
        {
        }

        public DbSet<PropertyManagement.Models.Customer_Detail> Customer_Detail { get; set; }

        public DbSet<PropertyManagement.Models.Dealer_Detail> Dealer_Detail { get; set; }

        public DbSet<PropertyManagement.Models.Property_Detail> Property_Detail { get; set; }

        public DbSet<PropertyManagement.Models.Property_Oction> Property_Oction { get; set; }
    }
}
