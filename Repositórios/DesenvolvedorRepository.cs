using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autenticacaoCadastro
{
    internal class DesenvolvedorRepository
    {
       public static void Save(Desenvolvedor desenvolvedor)
        {
            using (Repository repository = new Repository())  
            {
                repository.Desenvolvedores.Add(desenvolvedor);
                repository.SaveChanges();   
            }
        }

        public static Desenvolvedor  AutenticarEmail(String email)
        {
            try
            {
                using (Repository repo = new Repository())
                {
                    return repo.Desenvolvedores.Include("Credencial").Where(u => u.Credencial.Email == email).FirstOrDefault<Desenvolvedor>();
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public static void CadastrarDev( DateTime nascimento, String nome, bool admin, bool ativo, char nivel, String senha,
            String email)

        {
            using (Repository dbContext = new Repository())
            {
                Desenvolvedor dev = new Desenvolvedor();
                dev.Nome = nome;
                dev.Nascimento = nascimento;
                dev.Nivel = nivel;

                Credencial credencial = new Credencial();
                credencial.Senha = senha;
                credencial.Email = email;
                credencial.Administrador = admin;
                credencial.Ativo = ativo;
                dev.Credencial = credencial;
                credencial.Desenvolvedor = dev;
                Save(dev);
            }
        }
        public static List<Desenvolvedor> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Desenvolvedores.Include("Credencial").ToList();
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        public static List<Desenvolvedor> BuscarDev(String buscardev)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Desenvolvedores.Where(d => d.Nome.Contains(buscardev)).ToList();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}