namespace RazorPagesApp
{
    public class DbService: IDbService
    {
        private readonly HoomanDbContext _context;
        public DbService(HoomanDbContext dbContext)
        {
            this._context = dbContext;
        }

        public IList<Hooman> GetAllFromDatabase()
        {
            return this._context.ListOfHoomans.ToList<Hooman>();
        }

        public void SaveToDatabase(Hooman hooman)
        {
            this._context.Add(hooman);
            this._context.SaveChanges();
        }
    }
}
