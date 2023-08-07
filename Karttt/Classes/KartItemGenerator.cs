using Karttt.Interfaces;

namespace Karttt.Classes
{
    public class KartItemGenerator : IKartItemGenerator
    {
        private string GenerateRandomString()
        {
            Random rand = new Random();
            string generatedString = "";
            for (int i = 0; i < 10; i++)
            {
                char c = (char)(65 + rand.Next(26));
                generatedString += c;
            }
            return generatedString;
        }
        public IKartItem GetNewItem()
        {
            IKartItem generatedItem = new KartItem() { Name = this.GenerateRandomString() };
            return generatedItem;
        }
    }
}
