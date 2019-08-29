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
            return listaPessoa;
        }

        public static List<Pessoa> addPessoa(Pessoa pessoa)
        {
            listaPessoa.Add(pessoa);
            return listaPessoa;
        }

    }
}