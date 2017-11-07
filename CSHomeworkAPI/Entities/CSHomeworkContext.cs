using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSHomeworkAPI.Entities
{
    public class CSHomeworkContext : DbContext
    {
        public CSHomeworkContext(DbContextOptions<CSHomeworkContext> options)
                : base(options)
        {
        }

        public DbSet<Question> Question { get; set; }
    }

}