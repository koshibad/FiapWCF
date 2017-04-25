using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using LojaEntities;

namespace LojaService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class VendasService : IVendasService
    {
        readonly static List<Produto> _produtos = new List<Produto>()
        {
            new Produto { Id = 1, Nome = "Caneta" },
            new Produto { Id = 2, Nome = "Papel" },
            new Produto { Id = 3, Nome = "Lápis" },
        };

        public List<Produto> GetProdutosEstoque()
        {
            return _produtos;
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void RegistrarVenda(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}