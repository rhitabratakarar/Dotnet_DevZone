namespace mvctute.Services;

public interface ILoginService
{
    public bool PerformLogin(string email, string password);
}