using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;

namespace RazorPages.Pages.Index
{
    public class IndexModel : PageModel
    {
        public ClickerVM Clicker { get; set; } = new ClickerVM();
        public void OnGet()
        {
            Clicker.Clicker = 0;
            Clicker.msg = "Basic Click";
        }

        public void OnGetBetter()
        {
            Clicker.Clicker = 5;
            Clicker.msg = "Better Click";
        }
        public void OnGetBest(int count = 10)
        {
            Clicker.Clicker = count;
            Clicker.msg = "Best of Click";
        }
    }
}
