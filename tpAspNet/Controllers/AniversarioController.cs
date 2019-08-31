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
        // GET: Aniversario
        public ActionResult Index()
        {
            List<Pessoa> pessoaList = PessoaDal.listarPessoas();
            return View(pessoaList);
        }

        // GET: Aniversario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Aniversario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aniversario/Create
        [HttpPost]
        public ActionResult Create(Pessoa pessoa)
        {
            pessoa.PessoaId = this.createId();
            PessoaDal.addPessoa(pessoa);
            return RedirectToAction("Index");
        }

        // GET: Aniversario/Edit/5
        public ActionResult Edit(int id)
        {
            return View(buscarId(id));
        }

        // POST: Aniversario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Pessoa person)
        {
            foreach (Pessoa pessoa in PessoaDal.listarPessoas())
            {
                if(pessoa.PessoaId == id)
                {
                    //person.Nome = 
                }

            }

            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Aniversario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Aniversario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public Pessoa buscarId(int id)
        {
            Pessoa resultado = new Pessoa();
            foreach(Pessoa p in PessoaDal.listarPessoas())
            {
                if(p.PessoaId == id)
                {
                    resultado.PessoaId = id;
                    resultado.Nome = p.Nome;
                    resultado.DataAniversario = p.DataAniversario;
                    break;
                }
            }
            return resultado;
        }

        public void EditPessoa(int id, Pessoa p)
        {
            foreach(Pessoa pessoa in PessoaDal.listarPessoas())
            {
                if(pessoa.PessoaId == id)
                {
                    pessoa.Nome = p.Nome;
                    pessoa.SobreNome = p.SobreNome;
                    pessoa.DataAniversario = p.DataAniversario;
                    break;
                }
            }
        }

        public int createId()
        {
            int count = 0;
            return count +=1;
        }
    }
}
