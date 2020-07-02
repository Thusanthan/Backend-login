using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseLogin.Models
{
    public class LoginDetailCotext : DbContext
    {
        public LoginDetailCotext(DbContextOptions<LoginDetailCotext> options ) : base(options) 
        {

        }

        public DbSet<LoginDetail> Logindetails { get; set; }

    }
}
