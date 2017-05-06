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
    public interface INotasServiceAdmin
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void AtualizarNota(Nota nota);
    }
}
