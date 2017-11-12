using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSHomeworkAPI.Entities
{
    public class CSHomeworkContext : DbContext
    {
        public IConfiguration _configuration { get; }

        public CSHomeworkContext()
            : base()
        {
        }
        public CSHomeworkContext(DbContextOptions<CSHomeworkContext> options) : 
            base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }

}