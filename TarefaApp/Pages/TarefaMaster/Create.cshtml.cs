using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TarefaApp.Context;
using TarefaApp.Models;

namespace TarefaApp.Pages.TarefaMaster
{
    public class CreateModel : PageModel
    {
        private readonly TarefaApp.Context.AppDbContext _context;

        public CreateModel(TarefaApp.Context.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Tarefa Tarefa { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Tarefas == null || Tarefa == null)
            {
                return Page();
            }

            _context.Tarefas.Add(Tarefa);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
