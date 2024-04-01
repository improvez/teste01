using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _teste01.Models {
    public class Atendimento {
         public int Id { get; set; }
         public DateTime DtAtendimento  {get; set; }
         public Animal Animal { get; set; }
         public Veterinario Veterinario { get; set; }
         public string Observacao { get; set; }
         public float Peso { get; set; }
         public float Altura { get; set; }

    }
}
