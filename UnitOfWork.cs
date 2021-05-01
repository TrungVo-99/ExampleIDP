using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleIDP.Repositories;
using ExampleIDP.Repositories.Interfaces;

namespace ExampleIDP
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ApplicationDbContext _context;


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }


        public int SaveChanges()
        {
            return _context.SaveChanges();
        }


    }
}
