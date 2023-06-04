using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Animals.Models;

    public class AnimalsContext : DbContext
    {
        public AnimalsContext (DbContextOptions<AnimalsContext> options)
            : base(options)
        {
        }

        public DbSet<Animals.Models.Animal> Animal { get; set; }
    }
