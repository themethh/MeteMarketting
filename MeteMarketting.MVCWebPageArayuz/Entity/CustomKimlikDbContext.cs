using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MeteMarketting.MVCWebPageArayuz.Entity
{
    public class CustomKimlikDbContext:IdentityDbContext<CustomKimlikUser,CustomKimlikRole,string>
    {
        public CustomKimlikDbContext(DbContextOptions<CustomKimlikDbContext>options):base(options)
        {
        }
    }
}
