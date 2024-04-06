using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace ASPNETCore_DB.Data
{
    public class LoginDBContext : IdentityDbContext
    {
        public LoginDBContext(DbContextOptions<LoginDBContext> options) : base(options)
        {
        }
    }
}
