using Microsoft.EntityFrameworkCore;

public class IUTContext : DbContext
{
    public IUTContext(DbContextOptions<IUTContext> options) : base(options)
    {

    }
}