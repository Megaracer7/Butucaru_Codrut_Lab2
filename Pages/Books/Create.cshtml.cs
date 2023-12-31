﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Butucaru_Codrut_Lab2.Data;
using Butucaru_Codrut_Lab2.Models;

namespace Butucaru_Codrut_Lab2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Butucaru_Codrut_Lab2.Data.Butucaru_Codrut_Lab2Context _context;

        public CreateModel(Butucaru_Codrut_Lab2.Data.Butucaru_Codrut_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Book == null || Book == null)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
