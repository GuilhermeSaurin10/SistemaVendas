using Microsoft.EntityFrameworkCore;
using Repositorio.Interfaces;
using SistemaVendas.Dominio.Entidades;
using Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;
using Repositorio.Contexto;
using System.Linq;

namespace Repositorio.Entidades
{
    public class RepositorioVenda : Repositorio<Venda>, IRepositorioVenda
    {
        public RepositorioVenda(ApplicationDbContext dbContext) : base(dbContext) { }

        public override void Delete(int id)
        {
            //Antes precisamos excluir os id's de venda que estão na tabela venda_produtos

            var listaProdutos = DbSetContext.Include(x => x.Produtos).Where(y => y.Codigo == id).AsNoTracking().ToList();
            VendaProdutos vendaprodutos;

            foreach (var item in listaProdutos[0].Produtos)
            {
                vendaprodutos = new VendaProdutos();
                vendaprodutos.CodigoVenda = id;
                vendaprodutos.CodigoProduto = item.CodigoProduto;

                //Delete dos produtos da venda
                DbSet<VendaProdutos> DbSetAux;
                DbSetAux = Db.Set<VendaProdutos>();

                DbSetAux.Attach(vendaprodutos);
                DbSetAux.Remove(vendaprodutos);
                Db.SaveChanges();
            }

            //Delete da Venda
            base.Delete(id);
        }
    }
}
