using Karttt.Db;
using Karttt.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Karttt.Pages
{
    public class IndexModel : PageModel
    {
        private readonly KartDbContext _dbContext;
        public IList<IKartItem> AvailableKartItems { get; set; }
        public IndexModel(KartDbContext dbContext)
        {
            this._dbContext = dbContext;
            this.AvailableKartItems = new List<IKartItem>();
        }

        public async Task OnGetAsync()
        {
            this._dbContext.Database.EnsureCreated();
            this.AvailableKartItems = await this._dbContext.KartItems.ToListAsync<IKartItem>();
            foreach (IKartItem item in AvailableKartItems)
            {
                Debug.WriteLine(item.Id);
            }
        }

        public void OnPost()
        {

        }
    }
}