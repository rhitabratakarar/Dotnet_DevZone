namespace mvctute.Classes;
using mvctute.Interfaces;

public class Credential : ICredential
{
    public string? Email { get; set; }
    public string? Password { get; set; }
}