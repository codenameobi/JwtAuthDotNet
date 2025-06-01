using JwtAuthDotNet.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthDotNet.Data.Data;

public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}