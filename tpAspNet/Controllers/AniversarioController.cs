using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tpAspNet.Models;

namespace tpAspNet.Controllers
{
    public class AniversarioController : Controller
    {
        int countId = 3;

        //LISTA
        public ActionResult Index()
        {
            List<Pessoa> pessoaList = PessoaDal.listarPessoas();
            return View(pessoaList);
        }

        //DETALHES
        public ActionResult Details(int id)
        {
            return View(buscarPorId(id));
        }

        //CRIAÇÃO
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Pessoa pessoa)
        {
            pessoa.Id = this.createId();
            PessoaDal.addPessoa(pessoa);
            return RedirectToAction("Index");
        }

        //DELEÇÃO
        public ActionResult Delete(int id)
        {
            return View(buscarPorId(id));
        }
        [HttpPost]
        public ActionResult Delete(int id, Pessoa pessoa)
        {
            try
            {
                foreach (Pessoa pesquisa in PessoaDal.listarPessoas())
                {
                    if (pesquisa.Id == id)
                    {
                        PessoaDal.removePessoa(pesquisa);
                        break;
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //EDIÇÃO
        public ActionResult Edit(int id)
        {
            return View(buscarPorId(id));
        }
        [HttpPost]
        public ActionResult Edit(int id, Pessoa pessoa)
        {
            try
            {
                Pessoa p = pessoa;
                foreach (Pessoa pesquisa in PessoaDal.listarPessoas())
                {
                    if (pesquisa.Id == id)
                    {
                        pesquisa.Nome = p.Nome;
                        pesquisa.SobreNome = p.SobreNome;
                        pesquisa.DataAniversario = p.DataAniversario;
                        break;
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //BUSCA
        public ActionResult Search()
        {
            string pesquisa = "";
            return View(buscarPorNome(pesquisa));
        }
        [HttpPost]
        public ActionResult Search(string pesquisa)
        {
			List<Pessoa> listaDeBusca = buscarPorNome(pesquisa);

			try
            {
                return View(listaDeBusca);
            }
            catch
            {
                return View();
            }
        }

        //GENERICS
        public Pessoa buscarPorId(int id)
        {
            Pessoa resultado = new Pessoa();
            foreach (Pessoa p in PessoaDal.listarPessoas())
            {
                if (p.Id == id)
                {
                    resultado.Id = id;
                    resultado.Nome = p.Nome;
                    resultado.SobreNome = p.SobreNome;
                    resultado.DataAniversario = p.DataAniversario;
                    break;
                }
            }
            return resultado;
        }

        public List<Pessoa> buscarPorNome(string pesquisa)
        {
            List<Pessoa> resultadosList = new List<Pessoa>();
            foreach(Pessoa p in PessoaDal.listarPessoas())
            {
                if(p.Nome.ToLower().Contains(pesquisa.ToLower()))
                {
                    resultadosList.Add(p);
                }
            }
            return resultadosList;
        }

        public int createId()
        {
            this.countId += 1;
            return this.countId;
        }
    }
}
