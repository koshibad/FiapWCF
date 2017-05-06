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
        readonly EscolaContext _Context = new EscolaContext();

        [OperationBehavior(TransactionScopeRequired = true)]
        public void EnviarNotas(Nota nota)
        {
            if (_Context.Notas.Any(n => n.AlunoId == nota.AlunoId &&
                       n.DisciplinaId == nota.DisciplinaId))
            {
                ErroProcessamento ex = new ErroProcessamento
                {
                    Codigo = 999,
                    Messagem = string.Format("O aluno {0} já foi avaliado para a disciplina {1}",
                            _Context.Alunos.Find(nota.AlunoId).Nome,
                            _Context.Disciplinas.Find(nota.DisciplinaId).Nome),
                    Data = DateTime.Now.ToString()
                };

                throw new FaultException<ErroProcessamento>(ex, "Outra mensagem para o cliente");
            }

            nota.Aprovado = nota.Pontos >= 7;

            _Context.Notas.Add(nota);
            _Context.SaveChanges();
        }

        public List<Aluno> GetAlunos()
        {
            return _Context.Alunos.ToList();
        }

        public List<Disciplina> GetDisciplinas()
        {
            return _Context.Disciplinas.ToList();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
