using Microsoft.EntityFrameworkCore;
using UploadFilesWithFakeExtenstions.Models;

namespace UploadFilesWithFakeExtenstions.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    public DbSet<UploadedFile> UploadedFiles { get; set; }
}