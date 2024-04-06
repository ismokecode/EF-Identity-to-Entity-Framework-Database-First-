using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EF_DBFirst.Data;

public class EF_DBFirstContext : IdentityDbContext<IdentityUser>
{
    public EF_DBFirstContext(DbContextOptions<EF_DBFirstContext> options)
        : base(options)
    {
    }
    protected EF_DBFirstContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        //builder.Entity<IdentityUserLogin<String>>().HasKey();
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
