using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARCIAL1D
{
    public class ordenContext : DbContext
    {

        public ordenContext(DbContextOptions<ordenContext> options) : base(options)
        {

        }


    }
}
