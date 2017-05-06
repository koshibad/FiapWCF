using EscolaEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaService
{
    public class EscolaContext : DbContext
    {
        public EscolaContext() : base("SqlConnection")
        {
            Database.SetInitializer(new EscolaDBInitializer());
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Nota> Notas { get; set; }
    }
}
