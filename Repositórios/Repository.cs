using System;
using System.Data.Entity;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using autenticacaoCadastro.Classes_em_geral;

namespace autenticacaoCadastro
{
    
    internal class Repository : DbContext
    {
        private static MySqlConnection _databaseConnection;
        public DbSet<Desenvolvedor> Desenvolvedores { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Alocacao> Alocacoes { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }

        public Repository() : base(GetDbConnection(), false)
        {

            if (Database.CreateIfNotExists())
            {
                Repository r = this;

                Desenvolvedor d = new Desenvolvedor();
                d.Nome = "Eris";
                d.Nascimento = new DateTime(2005, 12, 18);
                d.Nivel = 'A';

                Credencial c = new Credencial();
                c.Email = "sire@gmail.com";
                c.Senha = "sire123456";
                c.Ativo = true;
                c.Administrador = true;

                Projeto p1 = new Projeto();
                p1.Nome = "Clube do Hacker";
                p1.Inicio = new DateTime(2021,11,18);
                p1.TerminoPlanejado = new DateTime(2023, 3, 20);
                p1.Termino = new DateTime(2023,3,67);

                Alocacao a1 = new Alocacao();
                a1.Inicio = new DateTime(2021, 4, 8);

                a1.Termino = new DateTime(2022,5,5);
                a1.HorasAtuacaoSemanal = 20;
                a1.Remuneracao = 50000;
                
                a1.Projeto = p1;
                a1.Desenvolvedor = d;
                p1.Alocacoes.Add(a1);
                                
                d.Credencial = c;
                c.Desenvolvedor = d;

                r.Desenvolvedores.Add(d);
                r.Alocacoes.Add(a1);
                r.Projetos.Add(p1);

                r.SaveChanges();
            }                     
        } 
        public static MySqlConnection GetDbConnection()
        {
            if (_databaseConnection == null)
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ProgVisConnectionString"].ConnectionString;
                _databaseConnection = new MySqlConnection(connectionString);
            }
            return _databaseConnection;
        }
    }
}

