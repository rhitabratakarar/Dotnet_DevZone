using System.Text.RegularExpressions;

class Program
{
    public static void Main()
    {
        string searchHere = "ThisIsTheStringToSea1rch";
        string search = "ear";
        string pattern = $"{search}";
        Regex reg = new Regex(pattern);
        MatchCollection matches = reg.Matches(searchHere);
        try
        {
            Match match = matches[0];
            GroupCollection groups = match.Groups;
            Console.WriteLine(groups[0].Index);
        }
        catch(Exception)
        {
            Console.WriteLine(-1);
        }
    }
}