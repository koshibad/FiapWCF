using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LojaEntities
{
    [DataContract]
    public class Produto
    {
        [DataMember(IsRequired = true)]
        public int Id { get; set; }
        [DataMember]
        public string Nome { get; set; }
    }
}
