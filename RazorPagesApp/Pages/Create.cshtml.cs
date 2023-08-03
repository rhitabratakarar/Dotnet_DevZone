using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Random _random;
        private readonly IDbService _service;
        public CreateModel(IDbService service)
        {
            this._random = new Random();
            this._service = service;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            this._service.SaveToDatabase(new()
            {
                Id = this._random.Next(int.MaxValue),
                Name = Request.Form["name"]!,
                AgeInYears = Convert.ToInt32(Request.Form["age"])
            });
            return RedirectToPage("./Index");
        }
    }
}