using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarManagementSystem1.Data;

namespace CarManagementSystem1.Data
{
    public class IdentityContext(DbContextOptions<IdentityContext> options) : IdentityDbContext<CarManagementSystem1User>(options)
    {
    }
}
