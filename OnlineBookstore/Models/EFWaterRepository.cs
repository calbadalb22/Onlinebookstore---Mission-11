
namespace OnlineBookstore.Models
{
    public class EFWaterRepository : IWaterRepository
    {
        private OnlineBookstoreContext _context;
        public EFWaterRepository(OnlineBookstoreContext temp) {
            _context = temp;
        }

        public IQueryable<Project> Projects => _context.Projects;
    }
}
