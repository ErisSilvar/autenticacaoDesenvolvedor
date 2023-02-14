using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autenticacaoCadastro
{
    [Table("Tb_Credencial")]
    internal class Credencial
    {
        public Int64 Id { get; set; }

        public Boolean Ativo = false;
        public Boolean Administrador = false;

        [Required]
        public Desenvolvedor Desenvolvedor { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(250)]
        public String Email { get; set; }

        public const String SALT = "1FnM6_";

        private String _senha;

        [Required]
        [StringLength(64)]
        public String Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                if (value.Length >= 8 && value.Length <= 12)
                {
                    _senha = ComputeSHA256(value, SALT);
                }
                else if (value.Length == 64)
                {
                    _senha = value;
                }
                else
                {
                    throw new ArgumentException("Erro");
                }
            }
        }
        public static String ComputeSHA256(String input)
        {
            return ComputeSHA256(input, null);
        }
        public static String ComputeSHA256(String input, String salt)
        {
            String hash = String.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(
                    Encoding.UTF8.GetBytes(salt + input));

                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }
            return hash;
        }
    }
}




