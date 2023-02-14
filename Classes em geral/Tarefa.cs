using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autenticacaoCadastro.Classes_em_geral
{
    [Table("tb_Tarefa")]
    internal class Tarefa
    {
        public Int64 Id { get; set; }

        [StringLength(200)]
        public String Descricao { get; set; }

        public Tarefa(String descricao)
        {
            Descricao = descricao;
        }

       public Alocacao Alocacao { get; set; } 

        public Tarefa()
        {

        }    
        public override string ToString()
        {
            return Id
                + ", " +  Descricao;
        }
    }
}
