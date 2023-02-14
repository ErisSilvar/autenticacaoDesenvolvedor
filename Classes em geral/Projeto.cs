using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autenticacaoCadastro
{
    [Table("Tb_Projeto")]
    internal class Projeto
    {

        [NotMapped]
        public List<Alocacao> Alocacoes;

        public Int64 Id { get; set; }

        [Required]
        [StringLength(35)]
        public String Nome { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime TerminoPlanejado { get; set; }
        public DateTime Termino { get; set; }

        public Projeto()
        {
            Alocacoes = new List<Alocacao>();
        }

        public override string ToString()
        {
            return  "Id: " + Id + " - " +"Nome: "  + Nome + " - " +
                 Inicio + " - "  + TerminoPlanejado + " - "  + Termino;
        }
    }
}
