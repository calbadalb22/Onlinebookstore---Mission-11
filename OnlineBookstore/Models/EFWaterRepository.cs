
namespace OnlineBookstore.Models
{
    public class EFWaterRepository : IWaterRepository
    {
        public IQueryable<Project> Projects => throw new NotImplementedException();
    }
}
