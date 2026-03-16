using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Data;
using RazorPages.Models;

namespace RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DataContext _context;

        public IndexModel(DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FormIEM Form { get; set; } = new FormIEM();

        public string Header { get; set; } = "Hello World!";
        public void OnGet()
        {
            Form.Name = "Baller";
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Submissions.Add(Form);

            await _context.SaveChangesAsync();

            return RedirectToPage("Success");

        }
    }
}
