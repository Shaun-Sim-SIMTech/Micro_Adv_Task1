using Microsoft.EntityFrameworkCore;


namespace Tasks_Assessment.Models;

public class Tasks_ServiceDBContext : DbContext
{
    public DbSet<Tasks_service> Tasks { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public Tasks_ServiceDBContext(DbContextOptions<Tasks_ServiceDBContext> options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        : base(options)
    {

    }
}
