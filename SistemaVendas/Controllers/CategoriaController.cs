using Aplicacao.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVendas.DAL;
using SistemaVendas.Entidades;
using SistemaVendas.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaVendas.Controllers
{
    public class CategoriaController : Controller
    {
        readonly IServicoAplicacaoCategoria ServicoAplicacaoCategoria;

        public CategoriaController(IServicoAplicacaoCategoria servicoAplicacaoCategoria)
        {
            ServicoAplicacaoCategoria = servicoAplicacaoCategoria;
        }

        public IActionResult Index()
        {
            return View(ServicoAplicacaoCategoria.Listagem());
        }

        //[HttpGet]
        //public IActionResult Cadastro(int? id)
        //{
        //    CategoriaViewModel viewModel = new CategoriaViewModel();

        //    if (id != null)
        //    {
        //        var entidade = mContext.Categoria.Where(x => x.Codigo == id).FirstOrDefault();
        //        viewModel.Codigo = entidade.Codigo;
        //        viewModel.Descricao = entidade.Descricao;
        //    }

        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Cadastro(CategoriaViewModel entidade)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Categoria objCategoria = new Categoria()
        //        {
        //            Codigo = entidade.Codigo,
        //            Descricao = entidade.Descricao
        //        };

        //        if (entidade.Codigo == null)
        //        {
        //            mContext.Categoria.Add(objCategoria);
        //        }
        //        else
        //        {
        //            mContext.Entry(objCategoria).State = EntityState.Modified;
        //        }

        //        mContext.SaveChanges();
        //    }
        //    else
        //    {
        //        return View(entidade);
        //    }

        //    return RedirectToAction("Index");
        //}

        //[HttpGet]
        //public IActionResult Excluir(int id)
        //{
        //    var ent = new Categoria() { Codigo = id, Descricao = "!" };
        //    mContext.Attach(ent);
        //    mContext.Remove(ent);
        //    mContext.SaveChanges();

        //    return RedirectToAction("Index");

        //}
    }
}
