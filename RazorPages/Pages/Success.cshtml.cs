using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.Data;
using RazorPages.Models;

namespace RazorPages.Pages
{
    public class SuccessModel : PageModel
    {
        private readonly DataContext _context;
        public SuccessModel(DataContext context)
        {
            _context = context;
        }
        public List<FormIEM> Submissions { get; set; } = default;

        public string Header = "Databáze Formuláře";

        public async Task OnGetAsync()
        {
            Submissions = await _context.Submissions.ToListAsync();
        }
    }
}
