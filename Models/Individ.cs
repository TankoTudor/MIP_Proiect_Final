using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;


using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ProiectFinal.Models
{
    public class Individ
    {
            [Key]
            public int IdUser { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Username { get; set; }

            public string Password { get; set; }

            public string RePassword { get; set; }

            public DateTime DataNastere { get; set; }

        

        public class PersoanaDBContext : DbContext
        {
            public DbSet<Individ> User { get; set; }
        }
    
    }
}