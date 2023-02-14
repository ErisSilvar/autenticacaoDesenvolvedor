using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autenticacaoCadastro
{
    internal class CredencialRepository
    {
        public static Boolean Autenticar(String email, String senha)
        {
            Desenvolvedor usuario = DesenvolvedorRepository.AutenticarEmail(email);
            if (usuario != null)
            {
                String s = usuario.Credencial.Senha;
                senha = Credencial.ComputeSHA256(senha, Credencial.SALT);

                Console.WriteLine($"{senha} + {Credencial.ComputeSHA256(senha, Credencial.SALT)} + {s}");

                if (s == senha)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }   
    }
}
