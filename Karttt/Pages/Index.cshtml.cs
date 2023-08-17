using Karttt.Classes;
using Karttt.Db;
using Karttt.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<IActionResult> OnGet()
        {
            this._dbContext.Database.EnsureCreated();
            this.AvailableKartItems = await this._dbContext.KartItems.ToListAsync<IKartItem>();
            return Page();
        }

        [BindProperty]
        public KartItem? KartItem {get; set;}
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Console.WriteLine("_______________________________ The Name is: " + KartItem!.Name + "____________________________________");
            Console.WriteLine("_______________________________ The Id is: " + KartItem!.Id + "____________________________________");
            return RedirectToPage("/Index");
        }
    }
}