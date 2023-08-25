using mvctute.Interfaces;

namespace mvctute.Classes;

public class DataSource : IDataSource
{
    public IList<ICredential> Data { get; set; }
    public DataSource()
    {
        this.Data = new List<ICredential>()
        {
            new Credential() { Email= "test@gmail.com", Password = "ThisIsPassword" }
        };
    }
}