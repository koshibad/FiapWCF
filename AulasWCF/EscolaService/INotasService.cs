using EscolaEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EscolaService
{
    [ServiceContract]
    public interface INotasService
    {
        [OperationContract]
        List<Disciplina> GetDisciplinas();
        [OperationContract]
        List<Aluno> GetAlunos();

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void EnviarNotas(Nota nota);
    }
}
