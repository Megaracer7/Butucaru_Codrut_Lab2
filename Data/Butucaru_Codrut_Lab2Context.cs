using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Butucaru_Codrut_Lab2.Models;

namespace Butucaru_Codrut_Lab2.Data
{
    public class Butucaru_Codrut_Lab2Context : DbContext
    {
        public Butucaru_Codrut_Lab2Context (DbContextOptions<Butucaru_Codrut_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Butucaru_Codrut_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
