using Directory.Core.Interfaces;
using Directory.Dto;
using Microsoft.EntityFrameworkCore;

namespace Directory.Data;
public class UnitOfWork(DbContext context) : IUnitOfWork
{
    public IRepository<Listing> ListingRepository { get; } = new ListingRepository(context);

    public void Save()
    {
        context.SaveChanges();
    }
}
