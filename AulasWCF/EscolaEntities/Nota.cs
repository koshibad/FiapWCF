using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EscolaEntities
{
    [DataContract]
    public class Nota
    {
        [DataMember(IsRequired = true)]
        public int AlunoId { get; set; }

        [DataMember(IsRequired = true)]
        public int DisciplinaId { get; set; }

        [DataMember(IsRequired = true)]
        public decimal Pontos { get; set; }

        [IgnoreDataMember]
        public bool Aprovado { get; set; }
    }
}
