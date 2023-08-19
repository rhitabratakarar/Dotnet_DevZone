using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Karttt.Interfaces;
using Karttt.Db;
using Karttt.Classes;

namespace Karttt.Pages
{
    public class CartModel : PageModel
    {
        private readonly KartDbContext _dbContext;
        public IList<IKartItem> KartItems { get; set; }
        public CartModel(KartDbContext dbContext)
        {
            this._dbContext = dbContext;
            this.KartItems = new List<IKartItem>();
        }
        public void OnGet()
        {
            this.KartItems = this._dbContext.KartItems.Where<IKartItem>(item => item.IsItemAddedToKart == true).ToList<IKartItem>();
        }
        [BindProperty]
        public KartItem KartItem {get; set;}
        public void OnPost()
        {
            Console.WriteLine(KartItem!.Id);
        }
    }
}
