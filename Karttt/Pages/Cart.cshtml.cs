using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Karttt.Interfaces;

namespace Karttt.Pages
{
    public class CartModel : PageModel
    {
        private readonly IKartService _service;
        public CartModel(IKartService service)
        {
            this._service = service;
        }
        public void OnGet()
        {
        }
    }
}
