using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CSHomeworkAPI.Entities;

namespace CSHomeworkAPI
{
    public class CSHomeworkContextFactory : IDesignTimeDbContextFactory<CSHomeworkContext>
    {
        private readonly IConfiguration _configuration;

        public CSHomeworkContextFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public CSHomeworkContext CreateDbContext(string[] args)
        {
            var connectionString = _configuration["connectionStrings:DefaultConnection"];

            var optionsBuilder = new DbContextOptionsBuilder<CSHomeworkContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new CSHomeworkContext(optionsBuilder.Options);
        }
    }
}
