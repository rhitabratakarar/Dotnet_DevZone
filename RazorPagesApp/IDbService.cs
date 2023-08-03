namespace RazorPagesApp
{
    public interface IDbService
    {
        public void SaveToDatabase(Hooman hooman);
        public IList<Hooman> GetAllFromDatabase();
    }
}
