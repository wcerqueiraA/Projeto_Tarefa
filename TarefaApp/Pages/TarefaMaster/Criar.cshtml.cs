using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TarefaApp.Context;
using TarefaApp.Models;

namespace TarefaApp.Pages.TarefaMaster
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;

        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Tarefa Tarefa { get; set; } = default!;
        

        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Tarefas == null || Tarefa == null)
            {
                return Page();
            }

            _context.Tarefas.Add(Tarefa);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Index");
        }
    }
}
