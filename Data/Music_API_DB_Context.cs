using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Music_Web_API.Model;

namespace Music_Web_API.Models
{
    public class Music_API_DB_Context : DbContext
    {
        public Music_API_DB_Context (DbContextOptions<Music_API_DB_Context> options)
            : base(options)
        {
        }

        public DbSet<Music_Web_API.Model.Music> Music { get; set; }
    }
}
