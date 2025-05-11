using Directory.Core.Generics;
using Directory.Dto;
using Microsoft.EntityFrameworkCore;

namespace Directory.Data;
public sealed class ListingRepository(DbContext context) : RepositoryBase<Listing>(context)
{
}
