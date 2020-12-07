using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppDay51.Models;

namespace WebAppDay51.Data
{
    public class PlayersContext : DbContext
    {
        public PlayersContext (DbContextOptions<PlayersContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppDay51.Models.Player> Player { get; set; }
    }
}
