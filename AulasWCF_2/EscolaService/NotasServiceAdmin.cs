using EscolaEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EscolaService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class NotasServiceAdmin : INotasServiceAdmin, IDisposable
    {
        readonly EscolaContext _Context = new EscolaContext();

        [OperationBehavior(TransactionScopeRequired = true)]
        public void AtualizarNota(Nota nota)
        {
            var hostIdentity = WindowsIdentity.GetCurrent().Name;
            var primaryIdentity = ServiceSecurityContext.Current.PrimaryIdentity.Name;
            var windowsIdentity = ServiceSecurityContext.Current.WindowsIdentity.Name;
            var threadIdentity = Thread.CurrentPrincipal.Identity.Name;

            var notaDb = _Context.Notas.SingleOrDefault(n => n.AlunoId == nota.AlunoId &&
                    n.DisciplinaId == nota.DisciplinaId);

            if (notaDb != null)
            {
                notaDb.Pontos = nota.Pontos;

                _Context.SaveChanges();
            }
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
