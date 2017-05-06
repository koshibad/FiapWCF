using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EscolaService
{
    [DataContract]
    public class ErroProcessamento
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Messagem { get; set; }
        [DataMember]
        public string Data { get; set; }
    }
}
