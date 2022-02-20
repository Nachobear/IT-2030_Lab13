﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab13.Models
{
    public class SalesContext : DbContext
    {
        public SalesContext(DbContextOptions<SalesContext> options) : base(options) { }

        public DbSet<Sales> Sales { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "Ada",
                    LastName = "Lovelace",
                    DateOfBirth = new DateTime(1956, 12, 19),
                    DateOfHire = new DateTime(1995, 1, 1),
                    ManagerId = 0
                },

                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Jimbo",
                    LastName = "Magilicutty",
                    DateOfBirth = new DateTime(1990, 12, 19),
                    DateOfHire = new DateTime(2018, 4, 11),
                    ManagerId = 1
                },

                new Employee
                {
                    EmployeeId = 3,
                    FirstName = "Mike",
                    LastName = "Wazowski",
                    DateOfBirth = new DateTime(1984, 1, 12),
                    DateOfHire = new DateTime(2012, 3, 24),
                    ManagerId = 1
                }

                );

            modelBuilder.Entity<Sales>().HasData(
                new Sales
                {
                    SalesId = 1,
                    Quarter = 4,
                    Year = 2019,
                    Amount = 23456,
                    EmployeeId = 2,
                },
                new Sales
                {
                    SalesId = 2,
                    Quarter = 1,
                    Year = 2020,
                    Amount = 34567,
                    EmployeeId = 2,
                },
                new Sales
                {
                    SalesId = 3,
                    Quarter = 2,
                    Year = 2019,
                    Amount = 43221,
                    EmployeeId = 3,
                },
                new Sales
                {
                    SalesId = 4,
                    Quarter = 2,
                    Year = 2020,
                    Amount = 53444,
                    EmployeeId = 3,
                },
                new Sales
                {
                    SalesId = 5,
                    Quarter = 3,
                    Year = 2020,
                    Amount = 12344,
                    EmployeeId = 1,
                }
             );




        }
    }
}
