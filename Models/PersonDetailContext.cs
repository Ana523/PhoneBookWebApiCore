using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookWebApi.Models
{
    public class PersonDetailContext : DbContext
    {
        public PersonDetailContext(DbContextOptions<PersonDetailContext> options) : base(options)
        {

        }

        public DbSet<PersonDetail> PersonDetails { get; set; }
    }
}
