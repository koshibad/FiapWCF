using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Key, Column(Order = 0)]
        public int AlunoId { get; set; }

        [DataMember(IsRequired = true)]
        [Key, Column(Order = 1)]
        public int DisciplinaId { get; set; }

        [DataMember(IsRequired = true)]
        [Required]
        public decimal Pontos { get; set; }

        [IgnoreDataMember]
        public bool Aprovado { get; set; }

        [IgnoreDataMember]
        public virtual Aluno Aluno { get; set; }
        [IgnoreDataMember]
        public virtual Disciplina Disciplina { get; set; }
    }
}
