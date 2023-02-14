using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autenticacaoCadastro
{
    internal class ProjetoRepository
    {
        public static void Save(Projeto projeto)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (projeto.Id == 0)
                    {
                        dbContext.Projetos.Add(projeto);
                    }
                    else
                    {
                        dbContext.Entry(projeto).State = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }             
            }
            catch(Exception)
            {
                throw;
            }
        } 
        public static void CadastrarProjeto( String nome, DateTime inicio, DateTime terminoPlanejado,DateTime termino)
        {
            using (Repository dbContext = new Repository())
            {
                Projeto projeto = new Projeto();
                projeto.Nome = nome;
                projeto.Inicio = inicio;
                projeto.Termino = termino;
                projeto.TerminoPlanejado= terminoPlanejado;
              
                Save(projeto);
            }
        }

        public static List<Projeto> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Projetos.ToList();
                }
            }

            catch (Exception)
            {
                throw;
            }
        }
       
        public static List<Projeto> BuscarProj(String buscarproj)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Projetos.Where(d => d.Nome.Contains(buscarproj)).ToList();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
