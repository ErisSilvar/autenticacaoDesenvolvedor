using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;


namespace autenticacaoCadastro
{
    [Table("Tb_Desenvolvedor")]
    internal class Desenvolvedor
    {
        [NotMapped]
        public List<Alocacao> Alocacoes;

        [Required]
        [StringLength(45)]
        public String Nome { get; set; }
        public Int64 Id { get; set; }
        public DateTime Nascimento { get; set; }

        [NotMapped]

        public Char Nivel { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]

        public String NivelDb
        {
            get {

                return Nivel.ToString();
             }
            set
            {
                Nivel = value[0];
            }
        }    
        public Credencial Credencial { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + " - " + "Nome: " + Nome + " Credencial: " +  Credencial?.Id;
        }

        public Desenvolvedor()
        {
            Alocacoes = new List<Alocacao>();
        }
    }
}
