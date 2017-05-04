using EscolaEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaService
{
    public class EscolaDBInitializer : CreateDatabaseIfNotExists<EscolaContext>
    {
        protected override void Seed(EscolaContext context)
        {
            context.Disciplinas.AddRange(new List<Disciplina>()
        {
            new Disciplina { Nome = "Matemática" },
            new Disciplina { Nome = "Português" },
            new Disciplina { Nome = "História" },
        });

            context.Alunos.AddRange(new List<Aluno>()
        {
            new Aluno { Nome = "João" },
            new Aluno { Nome = "Jorge" },
            new Aluno { Nome = "Lucas" },
        });

            base.Seed(context);
        }
    }
}
