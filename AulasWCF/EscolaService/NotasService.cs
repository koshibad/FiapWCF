using EscolaEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EscolaService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class NotasService : INotasService, IDisposable
    {
        //readonly static List<Nota> _notas = new List<Nota>();
        //readonly static List<Disciplina> _disciplinas = new List<Disciplina>()
        //{
        //    new Disciplina { Id = 1, Nome = "Matemática" },
        //    new Disciplina { Id = 2, Nome = "Português" },
        //    new Disciplina { Id = 3, Nome = "História" },
        //};
        //readonly static List<Aluno> _alunos = new List<Aluno>()
        //{
        //    new Aluno { Id = 1, Nome = "João" },
        //    new Aluno { Id = 2, Nome = "Jorge" },
        //    new Aluno { Id = 3, Nome = "Lucas" },
        //};

        readonly EscolaContext _Context = new EscolaContext();

        [OperationBehavior(TransactionScopeRequired = true)]
        public void EnviarNotas(Nota nota)
        {
            nota.Aprovado = nota.Pontos >= 7;

            //_notas.Add(nota);
            _Context.Notas.Add(nota);
            _Context.SaveChanges();
        }

        public List<Aluno> GetAlunos()
        {
            //return _alunos;
            return _Context.Alunos.ToList();
        }

        public List<Disciplina> GetDisciplinas()
        {
            //return _disciplinas;
            return _Context.Disciplinas.ToList();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
