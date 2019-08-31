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
                p1.Id = 1;
                p1.Nome = "Marcio";
                p1.SobreNome = "Souza";
                p1.DataAniversario = "02/19/1984";

                Pessoa p2 = new Pessoa();
                p2.Id = 2;
                p2.Nome = "João";
                p2.SobreNome = "Almeida";
                p2.DataAniversario = "02/19/1985";

                Pessoa p3 = new Pessoa();
                p3.Id = 3;
                p3.Nome = "Marisa";
                p3.SobreNome = "Silva";
                p3.DataAniversario = "02/19/1986";

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

        public static List<Pessoa> removePessoa(Pessoa pessoa)
        {
            listaPessoa.Remove(pessoa);
            return listaPessoa;
        }

    }
}