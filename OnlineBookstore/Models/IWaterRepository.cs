namespace OnlineBookstore.Models
{
    public interface IWaterRepository
    {
        public IQueryable<Project> Projects { get; }
    }
}
