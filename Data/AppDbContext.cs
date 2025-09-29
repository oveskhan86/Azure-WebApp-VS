using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace azure_app_oves.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    
    public DbSet<Employee> employees { get; set; }

}

