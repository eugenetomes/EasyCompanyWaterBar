using MediatR;
using Microsoft.EntityFrameworkCore;
using WaterBar.Application.Abstractions.Data;

namespace WaterBar.Persistence.Database;
public sealed class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IPublisher publisher)
    : DbContext(options), IApplicationDbContext
{
}
