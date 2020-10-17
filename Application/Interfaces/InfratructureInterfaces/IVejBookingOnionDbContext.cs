using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public interface IVejBookingOnionDbContext
    {
        DbSet<Student> Students { get; set; }
        DbSet<Teacher> Teachers { get; set; }
    }
}