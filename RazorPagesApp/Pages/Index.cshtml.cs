using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IDbService _dbService;
        public IList<Hooman> ListOfHooman { get; set; }

        public IndexModel(IDbService service)
        {
            this._dbService = service;
            this.ListOfHooman = new List<Hooman>();
        }

        public void OnGet()
        {
            ListOfHooman = this._dbService.GetAllFromDatabase();
        }
    }
}