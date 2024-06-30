using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TarefaApp.Context;
using TarefaApp.Models;

namespace TarefaApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Tarefa> Tarefa { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Tarefas != null)
            {
                Tarefa = await _context.Tarefas.ToListAsync();
            }
        }
    }
}
