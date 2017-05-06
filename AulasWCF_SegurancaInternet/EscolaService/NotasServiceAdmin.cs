using EscolaEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
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

        //[PrincipalPermission(SecurityAction.Demand, Role = "Users")]
        [OperationBehavior(TransactionScopeRequired = true)]
        public void AtualizarNota(Nota nota)
        {
            //var userRole = Thread.CurrentPrincipal.IsInRole("Users");

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
