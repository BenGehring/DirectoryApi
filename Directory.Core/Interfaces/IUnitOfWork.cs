using Directory.Dto;

namespace Directory.Core.Interfaces;

public interface IUnitOfWork
{
    IRepository<Listing> ListingRepository { get; }

    void Save();
}