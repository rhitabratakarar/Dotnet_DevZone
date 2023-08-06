using Karttt.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Karttt.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IKartItemGenerator _kartItemGenerator;
        public IList<IKartItem> GeneratedKartItems { get; set; }
        public IndexModel(IKartItemGenerator kartItemGenerator)
        {
            this._kartItemGenerator = kartItemGenerator;
            this.GeneratedKartItems = new List<IKartItem>();
        }

        public void OnGet()
        {
            for (int i = 0; i < 24; i++)
            {
                this.GeneratedKartItems.Add(_kartItemGenerator.GetNewItem());
            }
        }
    }
}