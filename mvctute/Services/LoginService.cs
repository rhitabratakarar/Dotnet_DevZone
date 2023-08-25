namespace mvctute.Services;
using mvctute.Interfaces;

public class LoginService : ILoginService
{
    private readonly IDataSource _source;

    public LoginService(IDataSource dataSource)
    {
        this._source = dataSource;
    }

    public bool PerformLogin(string email, string password)
    {
        // search for the credential in the data source.
        return this._source.Data.FirstOrDefault<ICredential>(c => c.Email == email && c.Password == password, null!) != null;
    }
}