using Microsoft.EntityFrameworkCore;

public class Lab1_Baranov_crossContext(DbContextOptions<Lab1_Baranov_crossContext> options) : DbContext(options)
{
    public DbSet<Lab1_Baranov_cross.Models.Movie> Movie { get; set; } = default!;
}
