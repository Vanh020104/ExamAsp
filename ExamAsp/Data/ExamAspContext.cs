using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExamAsp.Models;

namespace ExamAsp.Data
{
    public class ExamAspContext : DbContext
    {
        public ExamAspContext (DbContextOptions<ExamAspContext> options)
            : base(options)
        {
        }

        public DbSet<ExamAsp.Models.Department> Department { get; set; } = default!;

        public DbSet<ExamAsp.Models.Employee> Employee { get; set; } = default!;
    }
}
