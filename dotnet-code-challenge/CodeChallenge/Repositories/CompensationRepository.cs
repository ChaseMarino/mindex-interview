using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeChallenge.Models;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using CodeChallenge.Data;

namespace CodeChallenge.Repositories
{
    public class CompensationRepository : ICompensationRepository
    {
        private readonly EmployeeContext _context;

        public CompensationRepository(EmployeeContext context)
        {
            _context = context;
        }

        public Compensation Get(string employeeId)
        {
            return _context.Compensations.SingleOrDefault(c => c.EmployeeId == employeeId);
        }

        public void Add(Compensation compensation)
        {
            _context.Compensations.Add(compensation);
            _context.SaveChanges();
        }

        public Task SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
