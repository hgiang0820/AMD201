using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UrlShortenerService.Models;

namespace UrlShortenerService.Data
{
    public class UrlShortenerServiceContext : DbContext
    {
        public UrlShortenerServiceContext (DbContextOptions<UrlShortenerServiceContext> options)
            : base(options)
        {
        }

        public DbSet<UrlShortenerService.Models.Url> Url { get; set; } = default!;
    }
}
