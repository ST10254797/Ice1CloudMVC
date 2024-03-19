
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EmployeeApp.Data;
using System;
using System.Linq;
namespace EmployeeApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EmployeeAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EmployeeAppContext>>()))
            {
                // Look for any movies.
                if (context.Employee.Any())
                {
                    return;   // DB has been seeded
                }
                context.Employee.AddRange(
                    new Employee
                    {
                        Name = "Devesh",
                        Department = "IT",
                        Salary = 600000
                    },
                    new Employee
                    {
                        Name = "Mershen",
                        Department = "Accounting",
                        Salary = 500000
                    },
                    new Employee
                    {
                        Name = "Caden",
                        Department = "Law",
                        Salary = 1100000

                    },
                    new Employee
                    {

                        Name = "Preshen",
                        Department = "Health",
                        Salary = 650000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
