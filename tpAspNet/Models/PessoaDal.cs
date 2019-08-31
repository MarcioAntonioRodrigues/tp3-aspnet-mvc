using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tpAspNet.Models
{
    public static class PessoaDal
    {
        static List<Pessoa> listaPessoa = new List<Pessoa>();

        public static List<Pessoa> listarPessoas()
        {
            if(listaPessoa.Count() == 0)
            {
                Pessoa p1 = new Pessoa();
                p1.PessoaId = 1;
                p1.Nome = "Marcio";
                p1.SobreNome = "Souza";
                p1.DataAniversario = new DateTime(02/19/1984);

                Pessoa p2 = new Pessoa();
                p2.PessoaId = 2;
                p2.Nome = "Marcio";
                p2.SobreNome = "Souza";
                p2.DataAniversario = new DateTime(19/02/1984);

                Pessoa p3 = new Pessoa();
                p3.PessoaId = 3;
                p3.Nome = "Marcio";
                p3.SobreNome = "Souza";
                p3.DataAniversario = new DateTime(19/02/1984);

                listaPessoa.Add(p1);
                listaPessoa.Add(p2);
                listaPessoa.Add(p3);
            }

            return listaPessoa;
        }

        public static List<Pessoa> addPessoa(Pessoa pessoa)
        {
            listaPessoa.Add(pessoa);
            return listaPessoa;
        }

    }
}