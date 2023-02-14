using autenticacaoCadastro.Classes_em_geral;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autenticacaoCadastro.Repositories
{
    internal class AlocacaoRepository
    {
        public static void Save(Alocacao alocacao)
        {
            try
           {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Entry(alocacao.Desenvolvedor).State = EntityState.Unchanged;
                    dbContext.Entry(alocacao.Projeto).State = EntityState.Unchanged;

                    if (alocacao.Id == 0)
                    {
                        dbContext.Alocacoes.Add(alocacao);
                    }

                    else
                    {
                        dbContext.Entry(alocacao).State = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                    Console.WriteLine(dbContext.ChangeTracker);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

          public static List<Alocacao> BuscarAlocacao(String buscaralocacao)
          {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Alocacoes.Include("Desenvolvedor").Include("Projeto").Where(a => a.Desenvolvedor.Nome.Contains(buscaralocacao) || a.Projeto.Nome.Contains(buscaralocacao)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
          }

        public static void AdicionarTarefas(Alocacao alocacao, Tarefa tarefa)
        {
            try
            {
                using(Repository dbContext = new Repository())
                {
                    Alocacao alocacaodb = new Alocacao();
                    alocacaodb = dbContext.Alocacoes.FirstOrDefault(a => a.Id == alocacao.Id);
                    alocacaodb.ListTarefas.Add(tarefa);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
