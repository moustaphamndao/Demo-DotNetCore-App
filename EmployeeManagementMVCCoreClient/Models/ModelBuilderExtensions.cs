﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementMVCCoreClient.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                   new Employee
                   {
                       Id = 1,
                       Name = "Mary",
                       Department = Dept.HR,
                       Email = "mary@ndawene.com"
                   },
                    new Employee
                    {
                        Id = 2,
                        Name = "Mark",
                        Department = Dept.IT,
                        Email = "mark@ndawene.com"
                    }
               );
        }
    }
}
