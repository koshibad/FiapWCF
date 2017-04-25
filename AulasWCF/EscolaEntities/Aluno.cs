using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EscolaEntities
{
    [DataContract]
    public class Aluno
    {
        [DataMember(IsRequired = true)]
        public int Id { get; set; }
        [DataMember]
        public string Nome { get; set; }
    }
}
