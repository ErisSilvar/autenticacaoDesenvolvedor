using autenticacaoCadastro.Classes_em_geral;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autenticacaoCadastro
{
    [Table("tb_Alocacao")]
    internal class Alocacao
    {
        public Int64 Id { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public Byte HorasAtuacaoSemanal { get; set; }
        public Decimal Remuneracao { get; set; }

        public Desenvolvedor Desenvolvedor { get; set; }

        [Required]
        public Projeto Projeto { get; set; }

        public List<Tarefa> ListTarefas { get; set; } = new List<Tarefa>();   

        public Alocacao()
        {

        }
        public Alocacao(DateTime inicio, DateTime termino, Byte horasAtuacao, Decimal remuneracao, Desenvolvedor dev, Projeto proj)
        {         
                Inicio = inicio;
                Termino = termino;
                HorasAtuacaoSemanal = horasAtuacao;
                Remuneracao = remuneracao;
                Desenvolvedor = dev;
                Projeto = proj;
        }

        public override string ToString()
        {
            return "Dev: " +Desenvolvedor.Nome  + " - " + "Projeto: " + Projeto.Nome ;
        }
    }
}
