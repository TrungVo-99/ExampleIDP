using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleIDP.Repositories.Interfaces;

namespace ExampleIDP
{
    public interface IUnitOfWork
    {

        int SaveChanges();
    }
}
