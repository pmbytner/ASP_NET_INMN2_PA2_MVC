using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_NET_INMN2_PA2_MVC.Models;

namespace ASP_NET_INMN2_PA2_MVC.Data
{
    public class INMN2_PA2_MVCContext : DbContext
    {
        public INMN2_PA2_MVCContext (DbContextOptions<INMN2_PA2_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Miasto> Miasta { get; set; } = default!;
    }
}
