﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Butucaru_Codrut_Lab2.Data;
using Butucaru_Codrut_Lab2.Models;

namespace Butucaru_Codrut_Lab2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Butucaru_Codrut_Lab2.Data.Butucaru_Codrut_Lab2Context _context;

        public DetailsModel(Butucaru_Codrut_Lab2.Data.Butucaru_Codrut_Lab2Context context)
        {
            _context = context;
        }

      public Book Book { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}