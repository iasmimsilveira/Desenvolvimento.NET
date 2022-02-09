using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApi.Data
{
    public class DemoWebApiContext : DbContext
    {
        public DemoWebApiContext(DbContextOptions<DemoWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<DemoWebApi.Models.TodoItem> TodoItem { get; set; }
    }
}
