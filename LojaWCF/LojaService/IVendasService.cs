using LojaEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LojaService
{
    [ServiceContract]
    public interface IVendasService
    {
        [OperationContract]
        List<Produto> GetProdutosEstoque();
        [OperationContract]
        void RegistrarVenda(Produto produto);
    }
}
